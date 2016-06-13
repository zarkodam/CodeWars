using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars._4kyuBaseConversion
{
    public class Task
    {
        private static long GetBaseTen(string input, string sourceBase)
        {
            long result = 0;
            int pow = 0;

            for (int i = input.Length - 1; i >= 0; i--)
                result += sourceBase.IndexOf(input[i]) * (long)Math.Pow(sourceBase.Length, pow++);

            return result;
        }

        private static IEnumerable<int> ConvertFromBaseTen(long tenBaseNumber, int targetBase)
        {
            var result = new Stack<int>();

            while (true)
            {
                result.Push((int)(tenBaseNumber % targetBase));
                tenBaseNumber = tenBaseNumber / targetBase;
                if (tenBaseNumber == 0) break;
            }

            return result;
        }

        public static string Convert(string input, string source, string target)
        {
            return ConvertFromBaseTen(GetBaseTen(input, source), target.Length).Aggregate("", (current, index) => current + target[index]);
        }
    }
}
