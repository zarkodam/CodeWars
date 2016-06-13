using System.Collections.Generic;
using System.Linq;

namespace CodeWars._3kyuAlphabeticAnagrams
{
    public static class Task
    {
        public static double Factorial(this int factorial)
        {
            if (factorial == 0 || factorial == 1) return 1;

            double result = 1;

            for (int i = factorial; i > 0; i--) result *= i;

            return result;
        }

        private static Dictionary<char, int> _charsWithRepeatCount = new Dictionary<char, int>();

        private static double DuplicatesHandler(IEnumerable<char> valueCharsSorted, char currentChar)
        {
            _charsWithRepeatCount = valueCharsSorted.GroupBy(i => i).ToDictionary(i => i.Key, j => j.Count());

            List<int> duplicateValues = _charsWithRepeatCount.Values.ToList();

            double duplicateCount = duplicateValues[0].Factorial();

            for (int i = 1; i < duplicateValues.Count; i++)
                duplicateCount *= duplicateValues[i].Factorial();

            _charsWithRepeatCount.Remove(currentChar);

            return duplicateCount;
        }

        private static double _wordCombinationOrder = 1;

        private static void CalculateWordOrder(List<char> valueChars, List<char> valueCharsSorted)
        {
            for (int i = 0; i < valueChars.Count; i++)
                for (int j = 0; j < valueCharsSorted.Count; j++)
                    if (valueChars[i] == valueCharsSorted[j])
                    {
                        _wordCombinationOrder += j * (((valueCharsSorted.Count - 1) - i).Factorial() / DuplicatesHandler(valueCharsSorted, valueChars[i]));
                        valueChars.RemoveAt(i);
                        valueCharsSorted.RemoveAt(j);
                        CalculateWordOrder(valueChars, valueCharsSorted);
                    }
        }

        public static long ListPosition(string value)
        {
            CalculateWordOrder(value.Select(i => i).ToList(), value.Select(i => i).OrderBy(i => i).ToList());

            long wordOrder = (long)_wordCombinationOrder;

            _wordCombinationOrder = 1;

            return wordOrder;
        }
    }
}
