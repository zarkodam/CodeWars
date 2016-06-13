using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars._6kyuRaiseMeToTheThirdPowerSearchMyDivisors
{
    public class Task
    {
        //public static IEnumerable<int> GetNumberDivisors(long n)
        //{
        //    var numberDivisors = new List<int>();

        //    for (int i = 1; i <= n; i++)
        //        if (n % i == 0) numberDivisors.Add(i);

        //    return numberDivisors;
        //}


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

        public static long IntCubeSumDiv(long n)
        {
            var result = new List<long>();

            long j = 6;
            long counter = 0;

            while (true)
            {
                if ((long)Math.Pow(j, 3) % DivisorsSum(j) == 0)
                {
                    result.Add(j);
                    counter++;
                }

                if (counter == n) break;

                j++;
            }

            return result.Last();
        }
    }
}
