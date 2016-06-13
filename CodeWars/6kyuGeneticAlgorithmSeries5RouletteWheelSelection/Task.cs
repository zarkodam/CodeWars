using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars._6kyuGeneticAlgorithmSeries5RouletteWheelSelection
{
    public class Task
    {
        private static readonly Random Random = new Random();

        public static string Select(IEnumerable<string> population, IEnumerable<double> fitnesses)
        {
            var populationArray = population.ToArray();
            var fitnessesArray = fitnesses.ToArray();

            // Get fitness sum
            double fitnessesSum = fitnessesArray.Sum();

            // Get random value
            double value = Random.NextDouble() * fitnessesSum;

            // Locate the random value based on the fitness
            for (int i = 0; i < fitnessesArray.Length; i++)
            {
                value -= fitnessesArray[i];

                if (value <= 0)
                    return populationArray[i];
            }

            // In case of error
            return populationArray[fitnessesArray.Length - 1];
        }
    }
}
