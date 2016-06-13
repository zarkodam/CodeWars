using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars.StringCalculator
{
    public class InfixToReversePolishParser
    {
        #region Fields

        private string _convertedTask = "";
        private string _taskLineBefore = "";
        private readonly Stack<string> _operationsBuffer = new Stack<string>();
        private bool _isCurrentNegative = false;

        #endregion


        #region Parser

        public string Parse(string task)
        {
            string[] taskInLines = Regex.Split(PrepareTask(task).Replace(" ", ""), "(?<=[-+*/()^])|(?=[-+*/()^])").Where(i => i != "").ToArray();

            foreach (var taskLine in taskInLines)
            {
                if (IsNegative(taskLine))
                {
                    _isCurrentNegative = true;
                    continue;
                }

                if (!CalculatorUtilities.IsOperatorOrBracket(taskLine))
                {
                    _convertedTask += (IsNegativeNumber(taskLine) ? "-" : "") + (taskLine + " ");
                    _isCurrentNegative = false;
                }

                else
                    OperationsPriorityHandler(taskLine);

                _taskLineBefore = taskLine;
            }

            if (_operationsBuffer.Count > 0) OperationsPriorityHandler(isLast: true);

            return _convertedTask;
        }

        #endregion


        #region Helpers

        private static string HandleNegativeBrackets(string task)
        {
            IEnumerable<string> taskInBrackets = Regex.Split(task.Replace(" ", ""), "([-]{1}[(]{1}|[(]{1}|[)]{1})").Where(i => i != "").ToArray();

            string taskWithWrappedNegativeBrackets = "";
            var bracketsCache = new Stack<string>();
            string lastLine = "";

            // Handling negative brackets
            foreach (string currentLine in taskInBrackets)
            {
                if (CalculatorUtilities.IsOperator(lastLine.LastOrDefault().ToString()) && currentLine.Equals("-("))
                {
                    bracketsCache.Push("-(");
                    taskWithWrappedNegativeBrackets += "(0";
                }

                if (lastLine.Equals("-(") && currentLine.Equals("-("))
                    taskWithWrappedNegativeBrackets += "0";

                else if (currentLine.Equals("(") && bracketsCache.Count > 0)
                    bracketsCache.Push("(");

                else if (currentLine.Equals(")") && bracketsCache.Count > 0 && bracketsCache.Pop().Equals("-("))
                    taskWithWrappedNegativeBrackets += ")";


                lastLine = currentLine;
                taskWithWrappedNegativeBrackets += currentLine;
            }

            return taskWithWrappedNegativeBrackets;
        }

        private static string HandleSingleNumbersInBracketsAndRepeatingBrackets(string taskWithWrappedNegativeBrackets)
        {
            IEnumerable<string> taskInSingleNumbersInsideBrackets =
                Regex.Split(taskWithWrappedNegativeBrackets.Replace(" ", ""), "([(]{1}|[)]{1})").Where(i => i != "");

            string taskWithHandledSingleNumbersInsideBrackets = "";

            string lastLine = "";

            // Handling single numbers inside brackets
            foreach (string currentLine in taskInSingleNumbersInsideBrackets)
            {
                if (lastLine.Equals("(") && currentLine.Equals("("))
                    taskWithHandledSingleNumbersInsideBrackets += "0+";

                double number;
                if (double.TryParse(currentLine, out number))
                {
                    if (number < 0)
                        taskWithHandledSingleNumbersInsideBrackets += "0";
                    else
                        taskWithHandledSingleNumbersInsideBrackets += "0+";
                }

                lastLine = currentLine;
                taskWithHandledSingleNumbersInsideBrackets += currentLine;
            }

            return taskWithHandledSingleNumbersInsideBrackets;
        }

        private static string PrepareTask(string task)
        {
            return HandleSingleNumbersInBracketsAndRepeatingBrackets(HandleNegativeBrackets(task));
        }

        private void AddLastItemToConvertedTaskString(string item)
        {
            _convertedTask += item == "(" || item == ")" ? "" : item + " ";
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
                if (_operationsBuffer.Count < 1) return;

                string currentItem = emptyTheBracket ? currentLine : _operationsBuffer.Pop();

                AddLastItemToConvertedTaskString(currentItem);

                if (_operationsBuffer.Count < 1) return;

                string nextItem = _operationsBuffer.Pop();

                if (!nextItem.Equals("(")) OperationsPriorityHandler(nextItem, emptyTheBracket: true);
            }

            else if (_operationsBuffer.Count == 0) _operationsBuffer.Push(currentLine);

            else if (CalculatorUtilities.IsCurrentOperationPriorityBigger(currentLine, _operationsBuffer.Peek())) _operationsBuffer.Push(currentLine);

            else
            {
                AddLastItemToConvertedTaskString(_operationsBuffer.Pop());
                OperationsPriorityHandler(currentLine);
            }
        }

        private bool IsNegative(string currentLine)
        {
            return (_taskLineBefore == "" || _taskLineBefore == "(" || CalculatorUtilities.IsOperator(_taskLineBefore)) && currentLine.Equals("-");
        }

        private bool IsNegativeNumber(string currentLine)
        {
            return _isCurrentNegative && !CalculatorUtilities.IsOperatorOrBracket(currentLine);
        }

        #endregion
    }
}
