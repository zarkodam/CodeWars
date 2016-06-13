using NUnit.Framework;

namespace CodeWars._7kyuGeneticAlgorithmSeries2Mutation
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void Mutate100()
        {
            Assert.AreEqual("1111", Task.Mutate("0000", 1));
            Assert.AreEqual("0000", Task.Mutate("1111", 1));
        }

        [Test]
        public void Mutate0()
        {
            Assert.AreEqual("0000", Task.Mutate("0000", 0));
            Assert.AreEqual("1111", Task.Mutate("1111", 0));
        }
    }
}
