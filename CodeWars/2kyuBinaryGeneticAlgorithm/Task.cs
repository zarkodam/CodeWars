using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars._2kyuBinaryGeneticAlgorithm
{
    public class Task
    {
        public class GeneticAlgorithm
        {
            private static readonly Random Random = new Random();

            public class ChromosomeWrap
            {
                public string Chromosome { get; set; }
                public double Fitness { get; set; }
            }

            private string Generate(int length)
            {
                string binaryString = "";

                for (int i = 0; i < length; i++) binaryString += Random.Next(0, 2);

                return binaryString;
            }

            private string RouletteWheelSelection(IEnumerable<string> population, IEnumerable<double> fitnesses)
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
                    if (value <= 0) return populationArray[i];
                }

                // In case of error
                return populationArray[fitnessesArray.Length - 1];
            }

            private string Mutate(string chromosome, double probability)
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

            private IEnumerable<string> Crossover(string chromosome1, string chromosome2, double p_c)
            {
                string crossovered1 = "";
                string crossovered2 = "";

                for (int i = 0; i < chromosome1.Length; i++)
                {
                    if (Random.NextDouble() <= p_c)
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


            private static IEnumerable<ChromosomeWrap> MapPopulationFit(IEnumerable<string> population, Func<string, double> fitness)
            {
                return population.Select(chromosome => new ChromosomeWrap { Chromosome = chromosome, Fitness = fitness(chromosome) }).ToList();
            }

            private List<string> _population = new List<string>();

            private void PopulationEvolution(Func<string, double> fitness, double p_c, double p_m, int iterations = 100)
            {
                var fitnessForOriginalPopulation = new List<double>();
                double highestFitness = 0;

                _population.ForEach(i =>
                {
                    double currentFitness = fitness(i);
                    fitnessForOriginalPopulation.Add(currentFitness);
                    if (highestFitness < currentFitness) highestFitness = currentFitness;
                });

                var newPopulation = new List<string>();

                for (int i = 0; i < iterations; i++)
                {
                    string chromosome1 = RouletteWheelSelection(_population, fitnessForOriginalPopulation);
                    string chromosome2 = RouletteWheelSelection(_population, fitnessForOriginalPopulation);
                    string[] crossoveredChromosomes = Crossover(chromosome1, chromosome2, p_c).ToArray();
                    newPopulation.Add(Mutate(crossoveredChromosomes[0], p_m));
                    newPopulation.Add(Mutate(crossoveredChromosomes[1], p_m));
                }

                _population = newPopulation;

                if (highestFitness < 1) PopulationEvolution(fitness, p_c, p_m, iterations);
            }

            public string Run(Func<string, double> fitness, int length, double p_c, double p_m, int iterations = 100)
            {
                for (int i = 0; i < iterations; i++) _population.Add(Generate(length));

                PopulationEvolution(fitness, p_c, p_m, iterations / 2);

                return MapPopulationFit(_population, fitness).OrderByDescending(i => i.Fitness).First().Chromosome; // return chromosome with highest fitness
            }
        }
    }
}