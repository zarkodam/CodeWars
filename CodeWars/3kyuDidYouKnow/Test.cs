using NUnit.Framework;
using System.Collections.Generic;

namespace CodeWars._3kyuDidYouKnow
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void TestDictionary1()
        {
            var kata = new Task.Kata(new List<string> { "cherry", "pineapple", "melon", "strawberry", "raspberry" });
            Assert.AreEqual("strawberry", kata.FindMostSimilar("strawbery"));
            Assert.AreEqual("cherry", kata.FindMostSimilar("berry"));
        }

        [Test]
        public void TestDictionary2()
        {
            var kata = new Task.Kata(new List<string> { "brainfuck", "java", "ruby", "php", "python", "javascript", "coffeescript", "c", "cpp" });
            Assert.AreEqual("java", kata.FindMostSimilar("heaven"));
            Assert.AreEqual("javascript", kata.FindMostSimilar("javascript"));
        }
    }
}
