using System;

namespace CodeWars._6kyuIqTest
{
    // Description:
    // Bob is preparing to pass IQ test.The most frequent task in this test is to find out which one of the given numbers differs from the others. Bob observed that one number usually differs from the others in evenness.Help Bob — to check his answers, he needs a program that among the given numbers finds one that is different in evenness, and return a position of this number.
    // ! Keep in mind that your task is to help Bob solve a real IQ test, which means indexes of the elements start from 1 (not 0)

    public class Task
    {
        public class Iq
        {
            public static int Test(string numbers)
            {
                int[] checkOnThis = Array.ConvertAll(numbers.Split(' '), int.Parse);

                int[] evens = Array.FindAll(checkOnThis, i => i % 2 == 0);
                int[] odds = Array.FindAll(checkOnThis, i => i % 2 != 0);

                return evens.Length > odds.Length
                    ? Array.IndexOf(checkOnThis, odds[0]) + 1
                    : Array.IndexOf(checkOnThis, evens[0]) + 1;
            }

            // Djoums
            //public static int Test(string numbers)
            //{
            //    var mods = numbers.Split(' ').Select(n => int.Parse(n) % 2).ToList();
            //    var avg = mods.Average();
            //    return mods.FindIndex(n => Math.Abs(n - avg) > 0.5) + 1;
            //}
        }
    }
}
