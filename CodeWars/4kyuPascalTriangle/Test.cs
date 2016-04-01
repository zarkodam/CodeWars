using NUnit.Framework;
using System.Collections.Generic;

namespace CodeWars._4kyuPascalTriangle
{
    [TestFixture]
    public class Test
    {
        [Test]
        public static void Level1()
        {
            CollectionAssert.AreEqual(new List<int> { 1, 1, 1, 1, 2, 1, 1, 3, 3, 1 }, Task.PascalsTriangle(4));
        }
    }
}
