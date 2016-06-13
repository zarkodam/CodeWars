using System;
using System.Collections.Generic;

namespace CodeWars.StringCalculator
{
    public static class CalculatorUtilities
    {
        public static double Compute(string operation, double b, double a)
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

        public static bool IsOperator(string item)
        {
            return item == "^" || item == "*" || item == "/" || item == "+" || item == "-";
        }

        public static bool IsBracket(string item)
        {
            return item == "(" || item == ")";
        }

        public static bool IsOperatorOrBracket(string item)
        {
            return IsOperator(item) || IsBracket(item);
        }

        public static bool IsCurrentOperationPriorityBigger(string current, string old)
        {
            var priorityList = new Dictionary<string, int>
            {
                { "^", 1 },
                { "*", 2 },
                { "/", 2 },
                { "+", 3 },
                { "-", 3 },
                { "", 4 }
            };

            if (current == "(" || old == "(") return true;

            return priorityList[old] > priorityList[current];
        }

    }
}
