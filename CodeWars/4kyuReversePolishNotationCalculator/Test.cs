using NUnit.Framework;

namespace CodeWars._4kyuReversePolishNotationCalculator
{
    [TestFixture]
    public class CalcTest
    {
        [Test]
        public void ShouldWorkWithEmptyString()
        {
            Assert.AreEqual(0, Task.Evaluate(""), 0, "Should work with empty string");
        }

        [Test]
        public void ShouldParseNumbers()
        {
            Assert.AreEqual(3, Task.Evaluate("3"), 0, "Should parse numbers");
        }

        [Test]
        public void ShouldParseFloatNumbers()
        {
            Assert.AreEqual(3.5, Task.Evaluate("3.5"), 0, "Should parse float numbers");
        }

        [Test]
        public void ShouldSupportAddition()
        {
            Assert.AreEqual(4, Task.Evaluate("1 3 +"), 0, "Should support addition");
        }

        [Test]
        public void ShouldSupportMultiplication()
        {
            Assert.AreEqual(3, Task.Evaluate("1 3 *"), 0, "Should support multiplication");
        }

        [Test]
        public void ShouldSupportSubstraction()
        {
            Assert.AreEqual(-2, Task.Evaluate("1 3 -"), 0, "Should support substraction");
        }

        [Test]
        public void ShouldSupportDivision()
        {
            Assert.AreEqual(2, Task.Evaluate("4 2 /"), 0, "Should support division");
        }

        [Test]
        public void Complex()
        {
            Assert.AreEqual(4, Task.Evaluate("5 1 2 + 4 * + 3 -"), 0, "Should support division");
        }
    }
}
