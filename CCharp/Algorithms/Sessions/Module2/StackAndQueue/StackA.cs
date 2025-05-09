namespace Algorithms.Sessions.Module2.StackAndQueue
{
    /// <summary>
    /// Stack implementation using array
    /// Source: https://www.geeksforgeeks.org/stack-data-structure-introduction-program/
    /// Source: Https://leetcode.com/problems/implement-stack-using-queues/
    /// </summary>
    public class StackA
    {
        public int Top;
        public int Capacity;
        public int[] StackNodes;

        public StackA(int capacity)
        {
            Top = -1;
            Capacity = capacity;
            StackNodes = new int[Capacity];
        }

        /// <summary>
        /// Insert
        /// overflow condition if stack is full
        /// T.C -> O(1)
        /// </summary>
        /// <param name="value"></param>
        public bool Push(int value)
        {
            if (Top >= Capacity - 1)
            {
                return false;
            }

            Top++;
            StackNodes[Top] = value;

            return true;
        }

        /// <summary>
        /// Remove
        /// Underflow condition for stack empty
        /// T.C -> O(1)
        /// </summary>
        /// <returns></returns>
        public int Pop()
        {
            if (Top < 0)
            {
                return 0;
            }

            var elem = StackNodes[Top];
            Top--;
            return elem;
        }

        /// <summary>
        /// return the element from the top of the stack
        /// T.C -> O(1)
        /// </summary>
        /// <returns></returns>
        public int Peek()
        {
            if (Top < 0)
                return 0;

            var elem = StackNodes[Top];
            return elem;
        }

        /// <summary>
        /// overflow 
        /// T.C -> O(1)
        /// </summary>
        /// <returns></returns>
        public bool IsFull()
        {
            return Top >= Capacity - 1;
        }

        /// <summary>
        /// overflow
        /// T.C -> O(1)
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return Top < 0;
        }
    }
}
