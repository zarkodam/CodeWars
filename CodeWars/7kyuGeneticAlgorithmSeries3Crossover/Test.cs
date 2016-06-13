using NUnit.Framework;
using System.Linq;

namespace CodeWars._7kyuGeneticAlgorithmSeries3Crossover
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void _0_Crossover_Basic_Tests()
        {
            Assert.AreEqual("111", Task.Crossover("110", "001", 2).ElementAt(0));
            Assert.AreEqual("000", Task.Crossover("110", "001", 2).ElementAt(1));

            Assert.AreEqual("111110", Task.Crossover("111000", "000110", 3).ElementAt(0));
            Assert.AreEqual("000000", Task.Crossover("111000", "000110", 3).ElementAt(1));
        }
    }
}
