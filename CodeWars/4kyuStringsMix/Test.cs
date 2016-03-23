using NUnit.Framework;

namespace CodeWars._4kyuStringsMix
{
    [TestFixture]
    public class Test
    {
        [Test]
        public static void Test1()
        {
            Assert.AreEqual("2:eeeee/2:yy/=:hh/=:rr", Task.Mixing.Mix("Are they here", "yes, they are here"));
            Assert.AreEqual("1:ooo/1:uuu/2:sss/=:nnn/1:ii/2:aa/2:dd/2:ee/=:gg", Task.Mixing.Mix("looping is fun but dangerous", "less dangerous than coding"));
            Assert.AreEqual("1:aaa/1:nnn/1:gg/2:ee/2:ff/2:ii/2:oo/2:rr/2:ss/2:tt", Task.Mixing.Mix(" In many languages", " there's a pair of functions"));
            Assert.AreEqual("1:ee/1:ll/1:oo", Task.Mixing.Mix("Lords of the Fallen", "gamekult"));
            Assert.AreEqual("", Task.Mixing.Mix("codewars", "codewars"));
            Assert.AreEqual("1:nnnnn/1:ooooo/1:tttt/1:eee/1:gg/1:ii/1:mm/=:rr", Task.Mixing.Mix("A generation must confront the looming ", "codewarrs"));
        }
    }
}
