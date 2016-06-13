using NUnit.Framework;

namespace CodeWars._6kyuLucasNumbers
{
    [TestFixture]
    public class Test
    {
        [Test]
        public static void Test1()
        {
            Assert.AreEqual(123, Task.Lucasnum(-10));
        }

        [Test]
        public static void Test2()
        {
            Assert.AreEqual(-11, Task.Lucasnum(-5));
        }

        [Test]
        public static void Test3()
        {
            Assert.AreEqual(-1, Task.Lucasnum(-1));
        }

        [Test]
        public static void Test4()
        {
            Assert.AreEqual(2, Task.Lucasnum(0));
        }

        [Test]
        public static void Test5()
        {
            Assert.AreEqual(1, Task.Lucasnum(1));
        }

        [Test]
        public static void Test6()
        {
            Assert.AreEqual(11, Task.Lucasnum(5));
        }

        [Test]
        public static void Test7()
        {
            Assert.AreEqual(123, Task.Lucasnum(10));
        }
    }
}
