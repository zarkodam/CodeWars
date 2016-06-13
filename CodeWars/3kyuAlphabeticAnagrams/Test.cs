using NUnit.Framework;

namespace CodeWars._3kyuAlphabeticAnagrams
{
    [TestFixture]
    public class Test
    {
        [TestCase("A", 1)]
        [TestCase("QUESTION", 24572)]
        [TestCase("AAAB", 1)]
        [TestCase("BAAA", 4)]
        [TestCase("ABAB", 2)]
        [TestCase("BOOKKEEPER", 10743)]

        public void TestNumberToOrdinal(string value, long expected)
        {
            Assert.AreEqual(expected, Task.ListPosition(value), $"Input {value}");
        }
    }
}
