namespace Algorithms.Sessions.Module2.Tree
{
    /// <summary>
    /// Binary tree node
    /// </summary>
    public class Node
    {
        public int Value;
        public Node? Left;
        public Node? Right;
        public Node(int value = 0, Node? left = null, Node? right = null)
        {
            this.Value = value;
            this.Left = left;
            this.Right = right;
        }
    }
}
