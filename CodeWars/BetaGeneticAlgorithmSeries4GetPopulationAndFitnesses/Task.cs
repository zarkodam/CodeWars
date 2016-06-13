using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars.BetaGeneticAlgorithmSeries4GetPopulationAndFitnesses
{
    public class ChromosomeWrap
    {
        public string Chromosome { get; set; }
        public double Fitness { get; set; }
    }

    public class Task
    {
        public static IEnumerable<ChromosomeWrap> MapPopulationFit(IEnumerable<string> population, Func<string, double> fitness)
        {
            return population.Select(chromosome => new ChromosomeWrap { Chromosome = chromosome, Fitness = fitness(chromosome) }).ToList();
        }
    }
}
