using System.Collections.Generic;
using System.Linq;

namespace CodeWars._7kyuVampireNumbers
{
    public class Task
    {
        public static bool VampireTest(long x, long y)
        {
            List<int> digits = x.ToString().Select(i => i - '0').Concat(y.ToString().Select(i => i - '0')).ToList();
            IEnumerable<int> resultDigits = (x * y).ToString().Select(i => i - '0');

            foreach (var item in resultDigits) digits.Remove(item);

            return !digits.Any() && (x > 0 || y > 0);
        }

        // Seprum
        //public static bool VampireTest(long x, long y)
        //{
        //    return (x * y).ToString().OrderBy(c => c).SequenceEqual((x.ToString() + y).OrderBy(c => c));
        //}
    }
}
