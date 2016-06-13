using NUnit.Framework;

namespace CodeWars._5kyuConvertStringToCamelCase
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void KataTests()
        {
            Assert.AreEqual("theStealthWarrior", Task.ToCamelCase("the_stealth_warrior"), "Kata.ToCamelCase('the_stealth_warrior') did not return correct value");
            Assert.AreEqual("TheStealthWarrior", Task.ToCamelCase("The-Stealth-Warrior"), "Kata.ToCamelCase('The-Stealth-Warrior') did not return correct value");
        }
    }
}
