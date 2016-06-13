using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars.BetaMyBEDMASApprovedCalculator
{
    public class BedmasApprovedCalculator
    {
        private static double Compute(string operation, double b, double a)
        {
            switch (operation)
            {
                case "^":
                    return Math.Pow(a, b);
                case "*":
                    return a * b;
                case "/":
                    return a / b;
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                default:
                    return 0;
            }
        }

        private static bool IsOperator(string item)
        {
            return item == "^" || item == "*" || item == "/" || item == "+" || item == "-" || item == "(" || item == ")";
        }

        private static bool IsCurrentOperationPriorityBigger(string current, string old)
        {
            var priorityList = new Dictionary<string, int>
            {
                { "^", 1 },
                { "*", 2 },
                { "/", 2 },
                { "+", 3 },
                { "-", 3 },
                { "", 7 }
            };

            if (current == "(" || old == "(") return true;

            return priorityList[old] > priorityList[current];
        }

        private string _convertedTask = "";
        private string _taskLineBefore = "";
        private readonly Stack<string> _operationsBuffer = new Stack<string>();

        private void AddLastItemToConvertedTaskString(string item)
        {
            _convertedTask += item == "(" || item == ")" ? "" : item + " ";
        }

        private bool _isCurrentNegative = false;

        private bool IsNegative(string currentLine)
        {
            return (_taskLineBefore == "" || IsOperator(_taskLineBefore)) && currentLine.Equals("-");
        }

        private bool IsNegativeNumber(string currentLine)
        {
            return _isCurrentNegative && !IsOperator(currentLine);
        }

        private bool IsNegativeBracket(string currentLine)
        {
            return _isCurrentNegative && currentLine.Equals("(");
        }

        private void OperationsPriorityHandler(string currentLine = "", bool emptyTheBracket = false, bool isLast = false)
        {
            if (isLast)
            {
                AddLastItemToConvertedTaskString(_operationsBuffer.Pop());
                OperationsPriorityHandler(currentLine, isLast: _operationsBuffer.Count > 0);
            }

            else if (currentLine.Equals(")") || emptyTheBracket)
            {
                string currentItem = emptyTheBracket ? currentLine : _operationsBuffer.Pop();

                AddLastItemToConvertedTaskString(currentItem);

                string nextItem = _operationsBuffer.Pop();

                if (!nextItem.Equals("(")) OperationsPriorityHandler(nextItem, emptyTheBracket: true);
            }

            else if (_operationsBuffer.Count == 0) _operationsBuffer.Push(currentLine);

            else if (IsCurrentOperationPriorityBigger(currentLine, _operationsBuffer.Peek())) _operationsBuffer.Push(currentLine);

            else
            {
                AddLastItemToConvertedTaskString(_operationsBuffer.Pop());
                OperationsPriorityHandler(currentLine);
            }
        }

        private bool? _isNegativeBracketClosed;

        private bool IsNegativeBracketClosed(string currentLine)
        {
            return _isNegativeBracketClosed != null && _isNegativeBracketClosed == false && currentLine.Equals(")");
        }

        public string InfixToRpnConverter(string task = "-(-4 + 3) + 5 * -2")
        {
            string[] taskInLines = Regex.Split(task.Replace(" ", ""), "(?<=[-+*/()^])|(?=[-+*/()^])").Where(i => i != "").ToArray();

            foreach (var taskLine in taskInLines)
            {
                if (IsNegative(taskLine))
                {
                    _isCurrentNegative = true;
                    continue;
                }

                if (!IsOperator(taskLine))
                {
                    _convertedTask += (IsNegativeNumber(taskLine) ? "-" : "") + (taskLine + " ");
                    _isCurrentNegative = false;
                }

                else
                {
                    if (IsNegativeBracket(taskLine))
                    {
                        _convertedTask += "0 ";
                        _isNegativeBracketClosed = false;
                    }

                    OperationsPriorityHandler(taskLine);

                    if (IsNegativeBracketClosed(taskLine))
                    {
                        _convertedTask += "- ";
                        _isNegativeBracketClosed = true;
                    }
                }

                _taskLineBefore = taskLine;
            }

            if (_operationsBuffer.Count > 0) OperationsPriorityHandler(isLast: true);

            return _convertedTask;
        }

        public double ReversePolishCalc(string rpnTask)
        {
            if (string.IsNullOrEmpty(rpnTask)) return 0;

            var task = new List<string>(rpnTask.Split(' '));
            var taskBuffer = new Stack<double>();

            foreach (var taskLine in task)
            {
                if (string.IsNullOrEmpty(taskLine)) continue;

                taskBuffer.Push(
                    !IsOperator(taskLine)
                    ? double.Parse(taskLine)
                    : Compute(taskLine, taskBuffer.Pop(), taskBuffer.Pop())
                    );
            }

            return taskBuffer.Pop();
        }

        public double Calculate(string task)
        {
            return ReversePolishCalc(InfixToRpnConverter(task));
        }
    }
}
