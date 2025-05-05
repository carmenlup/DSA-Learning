namespace Algorithms.Tests.Sessions.Module2.LinkedList.SinglyLinkedList
{
    public class LinkedListTests
    {
        [Fact]
        public void Get_ShouldReturn_NodeValue()
        {

            Algorithms.Sessions.Module2.LinkedList.SinglyLinkedList.LinkedList linkedList = new Algorithms.Sessions.Module2.LinkedList.SinglyLinkedList.LinkedList();
            linkedList.AddAtTail(1);
            linkedList.AddAtTail(2);
            linkedList.AddAtTail(3);
            linkedList.AddAtTail(4);
            linkedList.AddAtTail(5);
            linkedList.AddAtTail(6);

            var output = linkedList.Get(4);
            Assert.Equal(5, output);

        }

        [Fact]
        public void Get_ShouldReturnMinusOne_IfHeadIsNull()
        {
            Algorithms.Sessions.Module2.LinkedList.SinglyLinkedList.LinkedList linkedList = new Algorithms.Sessions.Module2.LinkedList.SinglyLinkedList.LinkedList();

            var output = linkedList.Get(0);
            Assert.Equal(-1, output);
        }

        [Fact]
        public void GetNode_ShouldReturn_Node()
        {

            Algorithms.Sessions.Module2.LinkedList.SinglyLinkedList.LinkedList linkedList = new Algorithms.Sessions.Module2.LinkedList.SinglyLinkedList.LinkedList();
            //
            linkedList.AddAtTail(1);
            linkedList.AddAtTail(2);
            linkedList.AddAtTail(3);
            linkedList.AddAtTail(4);
            linkedList.AddAtTail(5);
            linkedList.AddAtTail(6);

            var output = linkedList.GetNode(4);
            Assert.Equal(5, output.Value);
            Assert.Equal(linkedList.head.Next.Next.Next.Next, output);

        }

        [Fact]
        public void GetNode_ShouldReturnNull_IfHeadIsNull()
        {
            Algorithms.Sessions.Module2.LinkedList.SinglyLinkedList.LinkedList linkedList = new Algorithms.Sessions.Module2.LinkedList.SinglyLinkedList.LinkedList();

            var output = linkedList.GetNode(0);
            Assert.Null(output);
        }

        [Fact]
        public void AddAtHead_ShouldReturn_LinkedListWithNewNodeAtTheBeginning()
        {
            Algorithms.Sessions.Module2.LinkedList.SinglyLinkedList.LinkedList linkedList = new Algorithms.Sessions.Module2.LinkedList.SinglyLinkedList.LinkedList();

            linkedList.AddAtHead(2);

            Assert.Equal(2, linkedList.head.Value);
        }

        [Fact]
        public void AddAtTail_ShouldReturn_LinkedListWithNewNodeAtTheEnd()
        {
            Algorithms.Sessions.Module2.LinkedList.SinglyLinkedList.LinkedList linkedList = new Algorithms.Sessions.Module2.LinkedList.SinglyLinkedList.LinkedList();
            linkedList.AddAtTail(1);
            linkedList.AddAtTail(2);

            Assert.Equal(1, linkedList.head.Value);
            Assert.Equal(2, linkedList.head.Next.Value);
        }

        [Fact]
        public void DeleteAtIndex_ShouldRemoveNodeFromTheLinkedList_ForGivenIndex()
        {
            Algorithms.Sessions.Module2.LinkedList.SinglyLinkedList.LinkedList linkedList = new Algorithms.Sessions.Module2.LinkedList.SinglyLinkedList.LinkedList();
            linkedList.AddAtHead(1);
            linkedList.AddAtTail(2);
            linkedList.AddAtTail(3);
            linkedList.DeleteAtIndex(1);

            Assert.Equal(1, linkedList.head.Value);
            Assert.Equal(3, linkedList.head.Next.Value);
        }

        [Fact]
        public void DeleteAtIndex_ShouldRemoveLastNode_WhenIsTail()
        {
            Algorithms.Sessions.Module2.LinkedList.SinglyLinkedList.LinkedList linkedList = new Algorithms.Sessions.Module2.LinkedList.SinglyLinkedList.LinkedList();
            linkedList.AddAtHead(1);
            linkedList.AddAtTail(2);
            linkedList.DeleteAtIndex(1);

            Assert.Equal(1, linkedList.head.Value);
            Assert.Null(linkedList.head.Next);
        }

        [Fact]
        public void DeleteAtIndex_ShouldRemoveHead_ForIndexZero()
        {
            Algorithms.Sessions.Module2.LinkedList.SinglyLinkedList.LinkedList linkedList = new Algorithms.Sessions.Module2.LinkedList.SinglyLinkedList.LinkedList();
            linkedList.AddAtHead(1);
            linkedList.AddAtTail(2);
            linkedList.DeleteAtIndex(0);

            Assert.Equal(2, linkedList.head.Value);
            Assert.Null(linkedList.head.Next);
        }

        [Fact]
        public void DeleteAtIndex_ShouldReturnNull_WhenIsOnlyOneNode()
        {
            Algorithms.Sessions.Module2.LinkedList.SinglyLinkedList.LinkedList linkedList = new Algorithms.Sessions.Module2.LinkedList.SinglyLinkedList.LinkedList();
            linkedList.AddAtHead(1);
            linkedList.DeleteAtIndex(0);

            Assert.Null(linkedList.head);
        }

        //["MyLinkedList","addAtHead","addAtTail","addAtIndex",
        //"get","deleteAtIndex","get"]
        //[[],[1],[3],[1,2],
        //[1],[1],[1]]
        [Fact]
        public void LinkedList_ShouldWorkAsExpected()
        {
            Algorithms.Sessions.Module2.LinkedList.SinglyLinkedList.LinkedList linkedList = new Algorithms.Sessions.Module2.LinkedList.SinglyLinkedList.LinkedList();
            linkedList.AddAtHead(1); // 1->null (0)
            linkedList.AddAtTail(3); // 1->3->null (1)
            linkedList.AddAtIndex(1, 2); //1->2->3->null (2)
            var node1 = linkedList.Get(1);
            Assert.Equal(2, node1);
            linkedList.DeleteAtIndex(1); //1->3->null (1)
            var unused = linkedList.Get(1);
            Assert.Equal(1, linkedList.head.Value);
            Assert.Equal(3, linkedList.head.Next.Value);
        }

        //["MyLinkedList","addAtHead","deleteAtIndex",
        //	"addAtHead","addAtHead","addAtHead","addAtHead","addAtHead",
        //	"addAtTail","get","deleteAtIndex","deleteAtIndex"]
        //[[],[2],[1],[2],[7],[3],[2],[5],[5],[5],[6],[4]]
        [Fact]
        public void LinkedList_ShouldWorkAsExpected2()
        {
            Algorithms.Sessions.Module2.LinkedList.SinglyLinkedList.LinkedList linkedList = new Algorithms.Sessions.Module2.LinkedList.SinglyLinkedList.LinkedList();
            linkedList.AddAtHead(2); //2-> 
            linkedList.DeleteAtIndex(1); //null
            linkedList.AddAtHead(2); // 2->null (0)
            linkedList.AddAtHead(7); // 7->2->null (1)
            linkedList.AddAtHead(3); // 3->7->2->null (2)
            linkedList.AddAtHead(2); // 2->3->7->2->null (3)
            linkedList.AddAtHead(5); // 5->2->3->7->2->null (4)
            linkedList.AddAtTail(5); // 5->2->3->7->2->5->null (5)
            var unused = linkedList.Get(5);
            linkedList.DeleteAtIndex(6);
            linkedList.DeleteAtIndex(4); //// 5->2->3->7->2->null (4)


            Assert.Equal(5, linkedList.head.Value);
            Assert.Equal(2, linkedList.head.Next.Value);
            Assert.Equal(3, linkedList.head.Next.Next.Value);
            Assert.Equal(7, linkedList.head.Next.Next.Next.Value);
        }
        //["MyLinkedList","addAtHead","get","addAtHead","addAtHead","deleteAtIndex","addAtHead","get","get","get","addAtHead","deleteAtIndex"]
        //[[],[4],[1],[1],[5],[3],[7],[3],[3],[3],[1],[4]]
        //["MyLinkedList","addAtHead","get",
        //"addAtHead","addAtHead","deleteAtIndex","addAtHead",
        //"get","get","get","addAtHead","deleteAtIndex"]
        //[[],[4],[1],
        //[1],[5],[3],[7],
        //[3],[3],[3],[1],[4]]
        [Fact]
        public void LinkedList_ShouldWorkAsExpected3()
        {
            Algorithms.Sessions.Module2.LinkedList.SinglyLinkedList.LinkedList linkedList = new Algorithms.Sessions.Module2.LinkedList.SinglyLinkedList.LinkedList();
            linkedList.AddAtHead(4); //4->null (0) 		
            var listNode1 = linkedList.Get(1);
            Assert.Equal(-1, listNode1);
            linkedList.AddAtHead(1); // 1->4->null (1)
            linkedList.AddAtHead(5); // 5->1->4->null (2)
            linkedList.DeleteAtIndex(3); // 5->1->4->null (1) //does not remove the node 4 !!!!!!
            var listNodeDel = linkedList.Get(2);
            Assert.Equal(4, listNodeDel);
            linkedList.AddAtHead(7); // 7->5->1->4->null (3)
            var listNode31 = linkedList.Get(3);
            Assert.Equal(4, listNode31);
            var unused = linkedList.Get(3);
            var unused1 = linkedList.Get(3);
            linkedList.AddAtHead(1); // 1->7->5->1->4->null (4)
            linkedList.DeleteAtIndex(4); // 1->7->5->1->null (3)		


            Assert.Equal(1, linkedList.head.Value);
            Assert.Equal(7, linkedList.head.Next.Value);
            Assert.Equal(5, linkedList.head.Next.Next.Value);
        }

        //["MyLinkedList","addAtHead","addAtTail","addAtIndex",
        //"get","deleteAtIndex","get","get",
        //"deleteAtIndex","deleteAtIndex","get","deleteAtIndex","get"]
        //[[],[1],[3],[1,2],
        //[1],[1],[1],[3],
        //[3],[0],[0],[0],[0]]
        [Fact]
        public void LinkedList_ShouldWorkAsExpected4()
        {
            Algorithms.Sessions.Module2.LinkedList.SinglyLinkedList.LinkedList linkedList = new Algorithms.Sessions.Module2.LinkedList.SinglyLinkedList.LinkedList();
            linkedList.AddAtHead(1); // 1->null (0)
            linkedList.AddAtTail(3); // 1->3->null (1)
            linkedList.AddAtIndex(1, 2); //1->2->3->null (2)
            var node1 = linkedList.Get(1);
            Assert.Equal(2, node1);
            linkedList.DeleteAtIndex(1); //1->3->null (1)
            var node2 = linkedList.Get(1);
            Assert.Equal(3, node2);
            var node3 = linkedList.Get(3);
            Assert.Equal(-1, node3);
            linkedList.DeleteAtIndex(3); //1->3->null (1)
            linkedList.DeleteAtIndex(0); //3->null (0)
            var node4 = linkedList.Get(0);
            Assert.Equal(3, node4);
            linkedList.DeleteAtIndex(0); //null (0)
            var node5 = linkedList.Get(0);
            Assert.Equal(-1, node5);
        }

        //["MyLinkedList","addAtIndex","get"]
        //[[],[1,0],[0]]

        [Fact]
        public void LinkedList_ShouldWorkAsExpected5()
        {
            Algorithms.Sessions.Module2.LinkedList.SinglyLinkedList.LinkedList linkedList = new Algorithms.Sessions.Module2.LinkedList.SinglyLinkedList.LinkedList();
            linkedList.AddAtIndex(1, 2); //null (2)
            var node1 = linkedList.Get(1);
            Assert.Equal(-1, node1);

        }
    }
}

