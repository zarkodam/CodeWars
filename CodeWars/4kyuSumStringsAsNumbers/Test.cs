using NUnit.Framework;

namespace CodeWars._4kyuSumStringsAsNumbers
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("8670", Task.SumStrings("00103", "08567"));
        }
    }
}
