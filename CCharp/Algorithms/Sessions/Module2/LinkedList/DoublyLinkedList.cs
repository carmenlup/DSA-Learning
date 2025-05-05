namespace Algorithms.Sessions.Module2.LinkedList
{
    public class DoublyLinkedList
    {
        public DoublyNode Head;
        public DoublyNode Tail;

        public void SetHead(DoublyNode doublyNode)
        {
            // Write your code here.
        }

        public void SetTail(DoublyNode doublyNode)
        {
            // Write your code here.
        }

        public void InsertBefore(DoublyNode doublyNode, DoublyNode doublyNodeToInsert)
        {
            // Write your code here.
        }

        public void InsertAfter(DoublyNode doublyNode, DoublyNode doublyNodeToInsert)
        {
            // Write your code here.
        }

        public void InsertAtPosition(int position, DoublyNode doublyNodeToInsert)
        {
            // Write your code here.
        }

        public void RemoveNodesWithValue(int value)
        {
            var node = Head;
            while (node != null)
            {
                var nodeToRemove = node;
                node = node.Next;
                if (nodeToRemove.Value == value)
                    Remove(nodeToRemove);
            }

        }

        public void Remove(DoublyNode doublyNode)
        {
            if (doublyNode == Head)
                Head = Head.Next;

            if (doublyNode == Tail)
                Tail = Tail.Prev;

            if (doublyNode.Prev != null)
                doublyNode.Prev.Next = doublyNode.Next;

            if (doublyNode.Next != null)
                doublyNode.Next.Prev = doublyNode.Prev;

            doublyNode.Prev = null;
            doublyNode.Next = null;
        }

        public bool ContainsNodeWithValue(int value)
        {
            var node = Head;
            while (node != null && node.Value != value)
            {
                node = node.Next;
            }

            return node != null;
        }


    }



}