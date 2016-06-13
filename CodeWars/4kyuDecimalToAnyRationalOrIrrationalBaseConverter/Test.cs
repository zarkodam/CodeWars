using NUnit.Framework;
using System;

namespace CodeWars._4kyuDecimalToAnyRationalOrIrrationalBaseConverter
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("103", Task.Convert(13, 0, Math.PI));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual("-3FB0K.B000", Task.Convert(-867832.5, 4, 22));
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual("0.31415", Task.Convert(0.314159265358979, 5, 10));
        }

        [Test]
        public void Test5()
        {
            Assert.AreEqual("-A", Task.Convert(-10, 0, 23));
        }

        [Test]
        public void Test6()
        {
            Assert.AreEqual("13", Task.Convert(13, 0, 10));
        }

        [Test]
        public void Test7()
        {
            Assert.AreEqual("-1364", Task.Convert(-509, 0, 6.85565460040104));
        }
    }
}
