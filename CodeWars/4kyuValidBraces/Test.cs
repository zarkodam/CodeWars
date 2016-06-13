using NUnit.Framework;

namespace CodeWars._4kyuValidBraces
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(Task.Brace.ValidBraces("(){}[]"), true);
        }

        [Test]
        public void Test2()
        {

            Assert.AreEqual(Task.Brace.ValidBraces("(}"), false);
        }

        [Test]
        public void Test3()
        {

            Assert.AreEqual(Task.Brace.ValidBraces("[(])"), false);
        }

        [Test]
        public void Test4()
        {

            Assert.AreEqual(Task.Brace.ValidBraces("([{}])"), true);
        }

        [Test]
        public void Test5()
        {

            Assert.AreEqual(Task.Brace.ValidBraces("({})[({})]"), true);
        }
    }
}
