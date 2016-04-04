using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars._4kyuNextBiggerNumberWithSameDigits
{
    public class Task
    {
        public class Kata
        {
            public static long NextBiggerNumber(long n)
            {
                var digits = n.ToString().Select(i => i - '0').ToList();
                var digitsUprage = new List<int>();

                int last = digits.Last();

                for (int i = digits.Count - 1; i >= 0; i--)
                {
                    if (digits[i] < last) break;

                    last = digits[i];
                    digitsUprage.Add(digits[i]);
                    digits.RemoveAt(i);
                }

                if (digits.Count == 0) return -1;

                var digitsLast = digits.Last();
                digits.RemoveAt(digits.LastIndexOf(digitsLast));

                for (int i = 0; i < digitsUprage.Count; i++)
                {
                    if (digitsUprage[i] <= digitsLast) continue;

                    digits.Add(digitsUprage[i]);
                    digitsUprage[i] = digitsLast;
                    break;
                }

                long result = Convert.ToInt64(string.Join("", digits.Concat(digitsUprage)));
                Console.WriteLine(result);
                return result == n || digits.Count + digitsUprage.Count == 1 ? -1 : result;
            }

            // haayhappen
            //public static long NextBiggerNumber(long n)
            //{
            //    String str = GetNumbers(n);
            //    for (long i = n + 1; i <= long.Parse(str); i++)
            //        if (GetNumbers(n) == GetNumbers(i))
            //            return i;
            //    return -1;
            //}
            //public static string GetNumbers(long number)
            //{
            //    return string.Join("", number.ToString().ToCharArray().OrderByDescending(x => x));
            //}

            // myjinxin2015
            //public static long NextBiggerNumber(long n)
            //{
            //    if (n < 10) return -1;
            //    string s = n + "";
            //    for (int i = s.Length - 2; i >= 0; i--)
            //    {
            //        if (s.Substring(i) != string.Concat(s.Substring(i).OrderByDescending(x => x)))
            //        {
            //            var t = string.Concat(s.Substring(i).OrderBy(x => x));
            //            var c = t.First(x => x > s[i]);
            //            return long.Parse(s.Substring(0, i) + c + string.Concat(t.Where((x, y) => y != t.IndexOf(c))));
            //        }
            //    }
            //    return -1;
            //}

        }
    }
}
