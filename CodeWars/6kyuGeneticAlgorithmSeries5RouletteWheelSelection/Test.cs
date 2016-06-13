using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars._6kyuGeneticAlgorithmSeries5RouletteWheelSelection
{
    public class Test
    {
        private readonly string[] _population = { "1", "2", "3" };
        private readonly double[] _fitnesses = { 0.05, 0.05, 0.90 };

        [Test]
        public void _0_Select_High_Chance_Should_Probably_Return()
        {
            for (int i = 0; i < 10; i++)
            {
                var results = new List<string>();

                for (int j = 0; j < 10; j++)
                    results.Add(Task.Select(_population, _fitnesses));

                var threes = results.Count(c => c == "3");
                Assert.IsTrue(threes >= 6, $"3 should be the most returned element, got {threes} returns");
            }
        }
    }
}
