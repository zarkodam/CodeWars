using NUnit.Framework;

namespace CodeWars._6kyuTribonacciSequence
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void Tests()
        {
            Assert.AreEqual(new double[] { 0 }, Task.Xbonacci.Tribonacci(new double[] { 1, 1, 1 }, 0));
            Assert.AreEqual(new double[] { 1 }, Task.Xbonacci.Tribonacci(new double[] { 1, 1, 1 }, 1));
            Assert.AreEqual(new double[] { 1, 1, 1, 3, 5, 9 }, Task.Xbonacci.Tribonacci(new double[] { 1, 1, 1 }, 6));
            Assert.AreEqual(new double[] { 1, 1, 1, 3, 5, 9, 17 }, Task.Xbonacci.Tribonacci(new double[] { 1, 1, 1 }, 7));
            Assert.AreEqual(new double[] { 1, 1, 1, 3, 5, 9, 17, 31 }, Task.Xbonacci.Tribonacci(new double[] { 1, 1, 1 }, 8));
            Assert.AreEqual(new double[] { 1, 1, 1, 3, 5, 9, 17, 31, 57 }, Task.Xbonacci.Tribonacci(new double[] { 1, 1, 1 }, 9));
            Assert.AreEqual(new double[] { 1, 1, 1, 3, 5, 9, 17, 31, 57, 105 }, Task.Xbonacci.Tribonacci(new double[] { 1, 1, 1 }, 10));
            Assert.AreEqual(new double[] { 0, 0, 1, 1, 2, 4, 7, 13, 24, 44 }, Task.Xbonacci.Tribonacci(new double[] { 0, 0, 1 }, 10));
            Assert.AreEqual(new double[] { 0, 1, 1, 2, 4, 7, 13, 24, 44, 81 }, Task.Xbonacci.Tribonacci(new double[] { 0, 1, 1 }, 10));


            Assert.AreEqual(new double[] { 0, 1, 1, 2, 4, 7, 13, 24, 44, 81 }, Task.Xbonacci.Tribonacci(new double[] { 0, 1, 1 }, 10));
        }
    }
}
