using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars._6kyuWhenSigma1FunctionHasEqualsValuesForAnIntegerAndItsReversedOne
{
    public class Task
    {
        private static readonly Dictionary<long, long> DivisorsCache = new Dictionary<long, long>();

        public static long DivisorsSum(long n)
        {
            if (DivisorsCache.ContainsKey(n)) return DivisorsCache[n];

            long sum = 0;

            for (int i = 1; i <= (int)(Math.Sqrt(n)); i += 1)
                if (n % i == 0)
                {
                    sum += i;

                    if (n / i != i) sum += n / i;
                }

            DivisorsCache[n] = sum;

            return sum;
        }

        public static int EqualSigma1(int nmax)
        {
            int result = 0;
            for (int i = 1; i <= nmax; i++)
            {
                int reversedNumb = int.Parse(string.Join("", i.ToString().ToCharArray().Reverse()));

                if (i.Equals(reversedNumb)) continue;

                if (DivisorsSum(i).Equals(DivisorsSum(reversedNumb))) result += i;
            }

            return result;
        }
    }
}
