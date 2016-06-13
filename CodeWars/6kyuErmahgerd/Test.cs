using NUnit.Framework;

namespace CodeWars._6kyuErmahgerd
{
    [TestFixture]
    public class Test
    {
        private void TestIsUpper(string text)
        {
            var ehrmahgerd = Task.Ermahgerd(text);
            Assert.AreEqual(ehrmahgerd.ToUpper(), ehrmahgerd);
        }

        [Test]
        public void Ermagherd_should_return_all_uppercase_letters()
        {
            TestIsUpper("coDeWars");
            TestIsUpper("ohmygod I LOVE codewars!");
        }

        [Test]
        public void Ermagherd_should_replace_vowels_with_er()
        {
            Assert.AreEqual("C SHERP", Task.Ermahgerd("c sharp"));
            Assert.AreEqual("RERGERXP", Task.Ermahgerd("regexp"));
            Assert.AreEqual("JERVERSCRERPT", Task.Ermahgerd("Javascript"));
            Assert.AreEqual("HERSKERLL", Task.Ermahgerd("Haskell"));
            Assert.AreEqual("PYTHERN", Task.Ermahgerd("Python"));
            Assert.AreEqual("RERBY", Task.Ermahgerd("Ruby"));
        }

        [Test]
        public void Ermagherd_should_erer_and_erh_with_er()
        {
            Assert.AreEqual("ER", Task.Ermahgerd("oh"));
            Assert.AreEqual("ER", Task.Ermahgerd("ae"));
        }

        [Test]
        public void Ermagherd_should_turn_my_into_mah()
        {
            Assert.AreEqual("MAH", Task.Ermahgerd("my"));
            Assert.AreEqual("ERMAHGERD ER MAH!", Task.Ermahgerd("ohmygod oh my!"));
        }

        [Test]
        public void Ermagherd_should_replace_double_rs_with_single_r()
        {
            Assert.AreEqual("GERL", Task.Ermahgerd("girl"));
            Assert.AreEqual("ERLGERERTHM", Task.Ermahgerd("algorithm"));
            Assert.AreEqual("ERMAHGERD MAH FERNCTERN WERKS", Task.Ermahgerd("ohmygod my function works"));
        }

        [Test]
        public void Ermagherd_should_translate_correctly()
        {
            Assert.AreEqual("MAH NERM ERS ERMAHGERD GERL ERND ER LERV CERDERWERS!", Task.Ermahgerd("my name is ohmygod girl and I love codewars!"));
            Assert.AreEqual("ERMAHGERD MAH FERVERERT PERKERMERN!", Task.Ermahgerd("ohmygod my favourite pokemon!"));
            Assert.AreEqual("GRERMPY CERT!! MAH FERVERERT CERT!", Task.Ermahgerd("grumpy cat!! my favourite cat!"));
            Assert.AreEqual("ERMAHGERD JERVERSCRERPT, HERSKERLL, PYTHERN, RERBY, JERV, C SHERP, CLERJER, CERFFERSCRERPT!! ER LERV THERM ERLL!!", Task.Ermahgerd("ohmygod javascript, haskell, python, ruby, java, c sharp, clojure, coffeescript!! I love them all!!"));
        }
    }
}
