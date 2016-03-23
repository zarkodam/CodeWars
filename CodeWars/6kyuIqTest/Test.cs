using NUnit.Framework;

namespace CodeWars._6kyuIqTest
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(3, Task.Iq.Test("2 4 7 8 10"));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(1, Task.Iq.Test("1 2 2"));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(2, Task.Iq.Test("1 2 1 1"));
        }
    }
}
