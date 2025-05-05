using Algorithms.Sessions.Module2.LinkedList.SinglyLinkedList;

namespace Algorithms.Sessions.Module2.LinkedList
{
    public class Session5LinkedList
    {
        /// <summary>
        /// 206. Reverse Linked List
        /// T.C = O(n)
        /// S.C = O(1)
        /// https://leetcode.com/problems/reverse-linked-list/
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public Node ReverseLinkedList(Node head)
        {
            Node previewNode = null;
            var currentNode = head;

            while (currentNode != null)
            {
                var nextNode = currentNode.Next;
                currentNode.Next = previewNode;
                previewNode = currentNode;
                currentNode = nextNode;
            }

            head = previewNode;
            return head;
        }
    }
}
