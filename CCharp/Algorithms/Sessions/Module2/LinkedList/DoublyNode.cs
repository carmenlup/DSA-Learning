using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sessions.Module2.LinkedList
{
    public class DoublyNode
    {
        public int Value;
        public DoublyNode? Prev;
        public DoublyNode? Next;

        public DoublyNode(int value, DoublyNode? prev = null, DoublyNode? next = null)
        {
            this.Value = value;
            Prev = prev;
            Next = next;
        }
    }
}
