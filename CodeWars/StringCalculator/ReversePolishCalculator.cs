using System.Collections.Generic;
using System.Linq;

namespace CodeWars.StringCalculator
{
    public class ReversePolishCalculator
    {
        public double Calculate(string rpnTask)
        {
            if (string.IsNullOrEmpty(rpnTask)) return 0;

            var task = new List<string>(rpnTask.Split(' '));
            var taskBuffer = new Stack<double>();

            foreach (var taskLine in task)
            {
                if (!string.IsNullOrEmpty(taskLine))
                {
                    taskBuffer.Push(
                    !CalculatorUtilities.IsOperatorOrBracket(taskLine)
                    ? double.Parse(taskLine)
                    : CalculatorUtilities.Compute(taskLine, taskBuffer.Pop(), taskBuffer.Pop())
                    );
                }

            }

            return taskBuffer.Count <= 1 ? taskBuffer.Pop() : taskBuffer.Sum();
        }
    }
}
