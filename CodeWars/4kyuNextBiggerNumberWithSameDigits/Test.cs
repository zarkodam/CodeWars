using NUnit.Framework;

namespace CodeWars._4kyuNextBiggerNumberWithSameDigits
{
    public class Test
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(21, Task.Kata.NextBiggerNumber(12));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(531, Task.Kata.NextBiggerNumber(513));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(2071, Task.Kata.NextBiggerNumber(2017));
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual(441, Task.Kata.NextBiggerNumber(414));
        }

        [Test]
        public void Test5()
        {
            Assert.AreEqual(414, Task.Kata.NextBiggerNumber(144));
        }

        [Test]
        public void Test6()
        {
            Assert.AreEqual(1234567908, Task.Kata.NextBiggerNumber(1234567890));
        }

        [Test]
        public void Test7()
        {
            Assert.AreEqual(123456785123446789, Task.Kata.NextBiggerNumber(123456784987654321));
        }

        [Test]
        public void Test8()
        {
            Assert.AreEqual(-1, Task.Kata.NextBiggerNumber(9876543210));
        }
    }
}
