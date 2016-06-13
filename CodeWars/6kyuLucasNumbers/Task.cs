using System.Collections.Generic;
using System.Linq;

namespace CodeWars._6kyuLucasNumbers
{
    public class Task
    {
        public static long Lucasnum(int n)
        {
            var cache = new List<long> { 2, 1 };
            if (n >= 0 && n <= 1) return cache[n];
            for (int i = 1; i < (n < 0 ? 0 - n : n); i++) cache.Add(cache[i - 1] + cache[i]);
            return n % 2 != 0 && n < 0 ? -cache.Last() : cache.Last();
        }


        // Worst possible solution
        //public static int Lucasnum(int n)
        //{
        //    if (n >= 0)
        //    {
        //        if (n == 0) return 2;
        //        if (n == 1) return 1;

        //        return Lucasnum(n - 1) + Lucasnum(n - 2);
        //    }

        //    if (n == 0) return -2;
        //    if (n == -1) return -1;

        //    return Lucasnum(n + 2) - Lucasnum(n + 1);
        //}
    }
}

