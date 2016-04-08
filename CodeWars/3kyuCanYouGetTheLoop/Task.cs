namespace CodeWars._3kyuCanYouGetTheLoop
{
    public class Task
    {
        public static int GetLoopSize(LoopDetector.Node startNode)
        {
            var turtle = startNode;
            var rabbit = startNode;

            int colisionCounter = 0;
            int loopLength = 0;

            while (rabbit.Next != null)
            {
                turtle = turtle.Next;
                rabbit = rabbit.Next.Next;

                if (turtle == rabbit) colisionCounter++;

                if (colisionCounter == 1) loopLength++;

                if (turtle != rabbit) continue;

                if (colisionCounter == 2) break;
            }

            return loopLength;
        }
    }

    public class LoopDetector
    {
        public class Node
        {
            public Node Next { get; set; }
            public int Data { get; set; }

            public Node() { }

            public Node(int data)
            {
                Data = data;
            }
        }

        private int _countOfAddedElements;

        private Node _searchedNode;
        private void NodeFind(Node firstElement, int index)
        {
            if (firstElement.Data.Equals(index)) _searchedNode = firstElement;
            else NodeFind(firstElement.Next, index);
        }

        public void CreateChain(int tailLenght, int loopLength, Node expandableNode, Node firstElement = null)
        {
            int numberOfElementsToChain = tailLenght + loopLength;

            if (_countOfAddedElements >= numberOfElementsToChain) return;

            _countOfAddedElements++;
            expandableNode.Next = new Node();
            expandableNode.Data = _countOfAddedElements;

            if (_countOfAddedElements == numberOfElementsToChain)
            {
                NodeFind(firstElement, tailLenght + 1);
                expandableNode.Next = _searchedNode;
                return;
            }

            CreateChain(tailLenght, loopLength, expandableNode.Next, firstElement);
        }
    }
}
