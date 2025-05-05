namespace Algorithms.Sessions.Module2.LinkedList.SinglyLinkedList
{
    /// <summary>
    /// 707. Design Linked List
    /// https://leetcode.com/problems/design-linked-list/description/
    /// </summary>
    public class LinkedList
    {
        public Node head;
        //todo track tail

        public LinkedList()
        {
            head = null;
        }

        public int Get(int index)
        {
            if (head == null)
                return -1;

            //var count = 0;
            var current = head;
            while (index > 0)
            {
                //break loop if is the last node;
                if (current.Next == null)
                    return -1;

                current = current.Next;
                index--;
                //count++;
            }

            //return -1 if no node at specified index or index exceed number of nodes
            if (current == null)
                return -1;

            return current.Value;
        }

        public Node GetNode(int index)
        {
            if (head == null)
                return head;

            //var count = 0;
            var current = head;

            while (index > 0)
            {
                current = current.Next;
                index--;
                //count++;
            }

            return current;
        }

        public void AddAtHead(int val)
        {
            if (head == null)
            {
                head = new Node(val);
                return;
            }

            var current = new Node(val)
            {
                Next = head
            };

            head = current;
        }

        public void AddAtTail(int val)
        {
            if (head == null)
            {
                head = new Node(val);
                return;
            }

            var current = head;
            while (current != null && current.Next != null)
            {
                current = current.Next;
            }

            var node = new Node(val);
            current.Next = node;
        }

        public void AddAtIndex(int index, int val)
        {
            if (index == 0)
            {
                AddAtHead(val);
                return;
            }

            if (head == null && index != 0)
                return;

            //var count = 0; i don't need count since i can use index
            var current = head;

            while (index - 1 > 0)
            {
                //if (count == index - 1)
                //break;

                current = current.Next;
                index--;
            }

            var nodeToAdd = new Node(val);
            var nextNode = current.Next;
            current.Next = nodeToAdd;
            current.Next.Next = nextNode;
        }

        public void DeleteAtIndex(int index)
        {

            var count = 0;
            var current = head;
            if (head == null || index < count)
                return;

            // delete head for index 0
            // or return null if is only one node
            if (index == 0)
            {
                current = current.Next;
                head = null;
                head = current;
                return;
            }

            // a -> b -> //c// -> d -> e ->null
            var prevNodeToDelete = GetNode(index - 1);


            //passed to next node. If is tail and index to remove delete it
            if (prevNodeToDelete == null || prevNodeToDelete.Next == null)
            {
                return;
            }

            //delete
            var temp = prevNodeToDelete.Next.Next;
            prevNodeToDelete.Next = temp;
        }

        #endregion
    }
}
