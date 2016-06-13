using NUnit.Framework;
using System;

namespace CodeWars.BetaMyBEDMASApprovedCalculator
{
    [TestFixture]
    public class Test
    {
        public bool Close(double a, double b)
        {
            return Math.Abs(a - b) < 0.000000001;
        }

        [Test]
        public void PublicTests()
        {
            Assert.AreEqual(true, Close(Task.Calculate("1+2"), 3));
            Assert.AreEqual(true, Close(Task.Calculate("2*2"), 4));
        }
    }
}
