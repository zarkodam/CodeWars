using System;
using System.Collections.Generic;

namespace CodeWars._4kyuReversePolishNotationCalculator
{
    public class Task
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
            return item == "^" || item == "*" || item == "/" || item == "+" || item == "-";
        }

        public static double Evaluate(string expr)
        {
            if (string.IsNullOrEmpty(expr)) return 0;

            var task = new List<string>(expr.Split(' '));
            var taskBuffer = new Stack<double>();

            foreach (var taskLine in task)
            {
                taskBuffer.Push(
                    !IsOperator(taskLine)
                    ? double.Parse(taskLine)
                    : Compute(taskLine, taskBuffer.Pop(), taskBuffer.Pop())
                    );
            }

            return taskBuffer.Pop();
        }
    }
}
