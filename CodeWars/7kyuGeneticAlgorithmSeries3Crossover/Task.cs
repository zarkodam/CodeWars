using System.Collections.Generic;

namespace CodeWars._7kyuGeneticAlgorithmSeries3Crossover
{
    public class Task
    {
        public static IEnumerable<string> Crossover(string chromosome1, string chromosome2, int cut)
        {
            string crossovered1 = "";
            string crossovered2 = "";

            for (int i = 0; i < chromosome1.Length; i++)
            {
                if (i < cut)
                {
                    crossovered1 += chromosome1[i];
                    crossovered2 += chromosome2[i];
                }
                else
                {
                    crossovered1 += chromosome2[i];
                    crossovered2 += chromosome1[i];
                }
            }

            return new List<string> { crossovered1, crossovered2 };
        }
    }
}
