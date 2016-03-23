using System;
using System.Linq;

namespace CodeWars._4kyuSumStringsAsNumbers
{
    public class Task
    {
        public static string SumStrings(string a, string b)
        {
            Console.WriteLine("a: {0}, b: {1}", a, b);

            int[] aNumbs = a.Select(c => c - '0').ToArray();
            int[] bNumbs = b.Select(c => c - '0').ToArray();

            // Decide which will be first
            bool isAGreaterThenB = aNumbs.Length > bNumbs.Length;
            int[] first = isAGreaterThenB ? aNumbs : bNumbs;
            int[] second = isAGreaterThenB ? bNumbs : aNumbs;

            int secondLength = second.Length - 1;

            int[] cache = new int[first.Length];
            int difference = 0;

            for (int i = first.Length - 1; i >= 0; i--)
            {
                int rowResult = first[i] + (secondLength >= 0 ? second[secondLength] : 0) + difference;
                int forAdd = rowResult % 10;

                cache[i] = forAdd;

                difference = (rowResult - forAdd) / 10;

                secondLength--;
            }

            string result = (difference != 0 ? difference.ToString() : "") + string.Join("", cache);

            return result.IndexOf('0') == 0 ? result.TrimStart('0') : result;
        }
    }
}
