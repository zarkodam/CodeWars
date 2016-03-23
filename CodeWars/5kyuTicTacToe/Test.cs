using NUnit.Framework;

namespace CodeWars._5kyuTicTacToe
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void Horizontal1()
        {
            int[,] board =
            {
                { 1, 1, 1 },
                { 0, 2, 2 },
                { 0, 0, 0 }
            };
            Assert.AreEqual(1, Task.TicTacToe.IsSolved(board));
        }

        [Test]
        public void Horizontal2()
        {
            int[,] board =
            {
                { 0, 1, 1 },
                { 2, 2, 2 },
                { 1, 0, 0 }
            };
            Assert.AreEqual(2, Task.TicTacToe.IsSolved(board));
        }

        [Test]
        public void Horizontal3()
        {
            int[,] board =
            {
                { 0, 1, 1 },
                { 0, 2, 2 },
                { 1, 1, 1 }
            };
            Assert.AreEqual(1, Task.TicTacToe.IsSolved(board));
        }

        [Test]
        public void Vertical1()
        {
            int[,] board =
            {
                { 2, 1, 1 },
                { 2, 1, 1 },
                { 2, 0, 2 }
            };
            Assert.AreEqual(2, Task.TicTacToe.IsSolved(board));
        }

        [Test]
        public void Vertical2()
        {
            int[,] board =
            {
                { 2, 1, 1 },
                { 0, 1, 2 },
                { 2, 1, 1 }
            };
            Assert.AreEqual(1, Task.TicTacToe.IsSolved(board));
        }

        [Test]
        public void Vertical3()
        {
            int[,] board =
            {
                { 2, 1, 1 },
                { 0, 1, 1 },
                { 2, 0, 1 }
            };
            Assert.AreEqual(1, Task.TicTacToe.IsSolved(board));
        }

        [Test]
        public void Slash()
        {
            int[,] board =
            {
                { 2, 2, 1 },
                { 0, 1, 1 },
                { 1, 0, 2 }
            };
            Assert.AreEqual(1, Task.TicTacToe.IsSolved(board));
        }

        [Test]
        public void BackSlash()
        {
            int[,] board =
            {
                { 2, 1, 1 },
                { 0, 2, 1 },
                { 2, 0, 2 }
            };
            Assert.AreEqual(2, Task.TicTacToe.IsSolved(board));
        }
    }
}
