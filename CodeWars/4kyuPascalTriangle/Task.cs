using System;
using System.Collections.Generic;

namespace CodeWars._4kyuPascalTriangle
{
    public static class Task
    {
        private static double Factorial(this int factorial)
        {
            if (factorial == 0 || factorial == 1) return 1;

            double result = 1;

            for (int i = factorial; i > 0; i--) result *= i;

            return result;
        }

        private static int Step(int n, int step)
        {
            return (int)Math.Round(n.Factorial() / (step.Factorial() * (n - step).Factorial()));
        }

        private static List<int> RowValue(int n)
        {
            if (n == 0) return new List<int> { 1 };

            var result = new List<int>();

            for (int i = 0; i < n; i++)
                result.Add(Step(n, i));

            result.Add(result[0]);

            return result;
        }

        public static List<int> PascalsTriangle(int n)
        {
            var result = new List<int>();

            for (int i = 0; i < n; i++)
                result.AddRange(RowValue(i));

            return result;
        }

        // _Alexey_
        //public static List<int> PascalsTriangle(int n)
        //{
        //    List<int> res = new List<int>() { 1 };
        //    for (int i = 2; i < n + 1; i++)
        //        for (int j = 0; j < i; j++)
        //            res.Add(j == 0 || j == i - 1 ? 1 : res[res.Count - i] + res[res.Count - i + 1]);
        //    return res;
        //}

        // Buttonsz
        //public static List<int> PascalsTriangle(int n)
        //{
        //    List<int> pt = new List<int>();

        //    pt.Add(1);
        //    for (int i = 1; i < n; i++)
        //    {
        //        for (int j = 0; j <= i; j++)
        //        {
        //            if (j == 0 || j == i)
        //                pt.Add(1);
        //            else
        //            {
        //                pt.Add(pt[pt.Count - i] + pt[pt.Count - (i + 1)]);
        //            }
        //        }
        //    }
        //    return pt;
        //}
    }
}
