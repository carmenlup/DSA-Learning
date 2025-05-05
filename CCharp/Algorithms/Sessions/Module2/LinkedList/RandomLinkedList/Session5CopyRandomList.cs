namespace Algorithms.Sessions.Module2.LinkedList.RandomLinkedList
{
    public class Session5CopyRandomList
    {
        // random linked list
        // 138. Copy List with Random Pointer
        // Source:https://leetcode.com/problems/copy-list-with-random-pointer/
        // T.C = O(n);
        // S.C = O(n);
        public Node CopyRandomList(Node head)
        {
            var temp = head;
            // step 1: create a new node and insert it after the original node
            while (temp != null)
            {
                var newNode = new Node(temp.val);
                newNode.next = temp.next;
                temp.next = newNode;
                temp = newNode.next;
            }

            //step 2: copy the random pointer
            var x = head;
            while (x != null)
            {
                var y = x.next;
                x.next.next = y.next;
                x = y.next.next;
            }

            //step 3: separate the two lists
            temp = head;
            var Head1 = temp.next;
            while (temp != null)
            {
                var temp1 = temp.next;
                temp.next = temp1.next;
                temp1.next = temp1.next.next;
                temp = temp.next;
            }

            return head;
        }
    }
}
