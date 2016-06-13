using System;
using System.Linq;

namespace CodeWars._4kyuHammingNumbers
{
    public class Task
    {
        public static long Hamming(int n)
        {
            long[] hamming = new long[n];
            hamming[0] = 1;

            long powOn2 = 2;
            long powOn3 = 3;
            long powOn5 = 5;

            int j = 0;
            int k = 0;
            int h = 0;

            for (int i = 1; i < n; i++)
            {
                hamming[i] = Math.Min(powOn2, Math.Min(powOn3, powOn5));

                if (hamming[i] == powOn2) powOn2 = 2 * hamming[++j];
                if (hamming[i] == powOn3) powOn3 = 3 * hamming[++k];
                if (hamming[i] == powOn5) powOn5 = 5 * hamming[++h];
            }

            return hamming.Last();
        }
    }
}
