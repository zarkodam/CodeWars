using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars._3kyuDidYouKnow
{
    public class Task
    {
        public class Kata
        {
            private readonly IEnumerable<string> _words;

            public Kata(IEnumerable<string> words)
            {
                _words = words.OrderBy(i => i);
                Console.Write(string.Join(", ", _words));
            }

            public string FindMostSimilar(string term)
            {
                double similarity = 0;
                string possibleSolution = term;

                foreach (var word in _words)
                {
                    double similarityTemp = GetSimilarity(term, word);

                    if (similarity < similarityTemp)
                    {
                        similarity = similarityTemp;
                        possibleSolution = word;
                    }
                }

                return possibleSolution;
            }

            public static double GetSimilarity(string a, string b)
            {
                string longer = a;
                string shorter = b;

                if (a.Length < b.Length)
                {
                    longer = b;
                    shorter = a;
                }

                int longerLength = longer.Length;

                if (longerLength == 0) return 1.0; // when a and b are 0

                // Max = 1.0, min = 0
                return (longerLength - EditDistance(longer, shorter)) / (double)longerLength;
            }

            // https://en.wikibooks.org/wiki/Algorithm_Implementation/Strings/Levenshtein_distance
            public static int EditDistance(string s1, string s2)
            {
                s1 = s1.ToLower();
                s2 = s2.ToLower();

                int[] costs = new int[s2.Length + 1];

                for (int i = 0; i <= s1.Length; i++)
                {
                    int lastValue = i;

                    for (int j = 0; j <= s2.Length; j++)
                    {
                        if (i == 0)
                            costs[j] = j;
                        else
                            if (j > 0)
                        {
                            int newValue = costs[j - 1];

                            if (s1[i - 1] != s2[j - 1])
                                newValue = Math.Min(Math.Min(newValue, lastValue), costs[j]) + 1;

                            costs[j - 1] = lastValue;
                            lastValue = newValue;
                        }
                    }

                    if (i > 0)
                        costs[s2.Length] = lastValue;
                }

                return costs[s2.Length];
            }

        }
    }
}
