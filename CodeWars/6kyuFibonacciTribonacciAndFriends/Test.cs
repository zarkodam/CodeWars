using NUnit.Framework;

namespace CodeWars._6kyuFibonacciTribonacciAndFriends
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void Tests()
        {
            Assert.AreEqual(new double[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 }, Task.Xbonacci(new double[] { 0, 1 }, 10));
            Assert.AreEqual(new double[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 }, Task.Xbonacci(new double[] { 1, 1 }, 10));
            Assert.AreEqual(new double[] { 0, 0, 0, 0, 1, 1, 2, 4, 8, 16 }, Task.Xbonacci(new double[] { 0, 0, 0, 0, 1 }, 10));
            Assert.AreEqual(new double[] { 1, 0, 0, 0, 0, 0, 1, 2, 3, 6 }, Task.Xbonacci(new double[] { 1, 0, 0, 0, 0, 0, 1 }, 10));



            Assert.AreEqual(new double[] { 9, 10, 10, 11, 0, 13, 10, 13, 3, 16, 8, 12, 13, 7, 3, 16, 154, 299, 588, 1166, 2321, 4642 }, Task.Xbonacci(new double[] { 9, 10, 10, 11, 0, 13, 10, 13, 3, 16, 8, 12, 13, 7, 3, 16 }, 22));
        }
    }
}
