using NUnit.Framework;

namespace CodeWars._5kyuGreedIsGood
{
    public class Test
    {
        [Test]
        public static void ShouldBeWorthless()
        {
            Assert.AreEqual(0, Task.Kata.Score(new int[] { 2, 3, 4, 6, 2 }), "Should be 0 :-(");
        }

        [Test]
        public static void ShouldValueTriplets()
        {
            Assert.AreEqual(400, Task.Kata.Score(new int[] { 4, 4, 4, 3, 3 }), "Should be 400");
        }

        [Test]
        public static void ShouldValueMixedSets()
        {
            Assert.AreEqual(450, Task.Kata.Score(new int[] { 2, 4, 4, 5, 4 }), "Should be 450");
        }

        [Test]
        public static void Test1()
        {
            Assert.AreEqual(1100, Task.Kata.Score(new int[] { 1, 1, 1, 1, 3 }), "Should be 1100");
        }
    }
}
