using NUnit.Framework;

namespace CodeWars._7kyuVampireNumbers
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(true, Task.VampireTest(21, 6), "Basic: 21 * 6 = 126 should return True");
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(true, Task.VampireTest(204, 615), "Basic: 204 * 615 = 125460 should return True");
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(true, Task.VampireTest(30, -51), "One Negative: 30 * -51 = -1530 should return True");
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual(false, Task.VampireTest(-246, -510), "Double Negatives: -246 * -510 = 125460 should return False (The negative signs aren't present on the product)");
        }
        [Test]
        public void Test5()
        {
            Assert.AreEqual(true, Task.VampireTest(210, 600), "Trailing Zeroes: 210 * 600 = 126000 should return True");
        }
        [Test]
        public void Test6()
        {
            Assert.AreEqual(false, Task.VampireTest(10, 11), "Trailing Zeroes: 10 * 11 = 110 should return False");
        }
    }
}
