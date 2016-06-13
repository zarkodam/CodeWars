using NUnit.Framework;

namespace CodeWars._4kyuRomanNumeralsDecoder
{
    [TestFixture]
    public class Test
    {
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(2014, "MMXIV")]
        [TestCase(2008, "MMVIII")]
        [TestCase(1990, "MCMXC")]
        [TestCase(1954, "MCMLIV")]
        [TestCase(4, "IV")]
        [TestCase(6, "VI")]
        [TestCase(7, "VII")]
        [TestCase(100, "C")]
        [TestCase(500, "D")]
        [TestCase(1000, "M")]
        public static void Test1(int expected, string roman)
        {
            Assert.AreEqual(expected, Task.Solution(roman));
        }
    }
}
