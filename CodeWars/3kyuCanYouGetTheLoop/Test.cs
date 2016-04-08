using NUnit.Framework;

namespace CodeWars._3kyuCanYouGetTheLoop
{
    public class Test
    {
        [Test]
        public void FourNodesWithLoopSize3()
        {
            var loopDetector = new LoopDetector();
            LoopDetector.Node rootNode = new LoopDetector.Node();
            loopDetector.CreateChain(2, 3, rootNode, rootNode);
            Assert.AreEqual(3, Task.GetLoopSize(rootNode));
        }

        [Test]
        public void RandomChainNodesWithLoopSize30()
        {
            var loopDetector = new LoopDetector();
            LoopDetector.Node rootNode = new LoopDetector.Node();
            loopDetector.CreateChain(3, 30, rootNode, rootNode);
            Assert.AreEqual(30, Task.GetLoopSize(rootNode));
        }

        //[Test]
        //public void RandomLongChainNodesWithLoopSize1087()
        //{
        //    var loopDetector = new LoopDetector();
        //    LoopDetector.Node rootNode = new LoopDetector.Node();
        //    loopDetector.CreateChain(3904, 1087, rootNode, rootNode);
        //    Assert.AreEqual(1087, Task.GetLoopSize(rootNode));
        //}
    }
}
