using System;
using System.Linq;

namespace CodeWars._7kyuGeneticAlgorithmSeries2Mutation
{
    public class Task
    {
        private static readonly Random Random = new Random();

        public static string Mutate(string chromosome, double probability)
        {
            int[] genes = chromosome.Select(i => i - '0').ToArray();

            for (int i = 0; i < chromosome.Length; i++)
            {
                if (!(Random.NextDouble() <= probability)) continue;

                if (genes[i] == 0) genes[i] = 1;
                else genes[i] = 0;
            }

            return string.Join("", genes);
        }
    }
}
