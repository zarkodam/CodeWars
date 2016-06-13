using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars._7kyuNumbersWhichSumOfPowersOfItsDigitsIsTheSameNumber
{
    public class Task
    {
        public static long[] EqSumPowDig(long hmax, int exp)
        {
            var result = new Stack<long>();
            var tempResult = new List<long>();

            for (long currenNumber = hmax; currenNumber > 1; currenNumber--)
            {
                tempResult.AddRange(currenNumber.ToString().Select(i => i - '0').ToArray().Select(digit => (long)Math.Pow(digit, exp)));

                if (currenNumber.Equals(tempResult.Sum())) result.Push(currenNumber);

                tempResult.Clear();
            }

            return result.ToArray();
        }
    }
}
