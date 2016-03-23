using NUnit.Framework;

namespace CodeWars._6kyuVasyaClerk
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("YES", Task.Line.Tickets(new[] { 25, 25, 25, 25, 50, 100, 50 }));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual("NO", Task.Line.Tickets(new[] { 25, 25, 25, 25, 25, 25, 25, 50, 50, 50, 100, 100, 100, 100 }));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual("NO", Task.Line.Tickets(new[] { 25, 25, 50, 50, 100 }));
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual("YES", Task.Line.Tickets(new[] { 25, 25, 25, 25, 25, 25, 25, 25, 25, 25 }));
        }



        [Test]
        public void Test5()
        {
            Assert.AreEqual("NO", Task.Line.Tickets(new[] { 25, 25, 50, 50, 100 }));
        }

        [Test]
        public void Test6()
        {
            Assert.AreEqual("NO", Task.Line.Tickets(new[] { 25, 25, 25, 25, 25, 100, 100 }));
        }

        [Test]
        public void Test7()
        {
            Assert.AreEqual("YES", Task.Line.Tickets(new[] { 25, 25, 25, 25, 25, 25, 25, 25, 25, 25 }));
        }

        [Test]
        public void Test8()
        {
            Assert.AreEqual("NO", Task.Line.Tickets(new[] { 50, 50, 50, 50, 50, 50, 50, 50, 50, 50 }));
        }

        [Test]
        public void Test9()
        {
            Assert.AreEqual("NO", Task.Line.Tickets(new[] { 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 }));
        }

        [Test]
        public void Test10()
        {
            Assert.AreEqual("YES", Task.Line.Tickets(new[] { 25, 25, 25, 25, 50, 100, 50 }));
        }

        [Test]
        public void Test11()
        {
            Assert.AreEqual("NO", Task.Line.Tickets(new[] { 50, 100, 100 }));
        }

        [Test]
        public void Test12()
        {
            Assert.AreEqual("NO", Task.Line.Tickets(new[] { 25, 25, 25, 25, 25, 25, 25, 50, 50, 50, 100, 100, 100, 100 }));
        }
    }
}
