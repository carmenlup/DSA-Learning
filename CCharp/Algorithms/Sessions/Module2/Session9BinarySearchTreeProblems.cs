using Algorithms.Sessions.Module2.Tree;

namespace Algorithms.Sessions.Module2
{
    public class Session9BinarySearchTreeProblems
    {
        /// <summary>
        /// Easy
        /// 700. Search in a Binary Search Tree
        /// https://leetcode.com/problems/search-in-a-binary-search-tree/description/
        /// Recursive solution
        /// T.C = O(h) where h is the height of the tree
        /// S.C = O(h) where h is the height of the tree
        /// </summary>
        /// <param name="root"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public Node? SearchRecursive(Node? root, int val)
        {
            if(root == null)
                return root;

            if (val == root.Value)
                return root;

            if (val < root.Value)
                return SearchRecursive(root.Left, val);
            

            return SearchRecursive(root.Right, val);
        }

        /// <summary>
        /// Easy
        /// 700. Search in a Binary Search Tree
        /// https://leetcode.com/problems/search-in-a-binary-search-tree/description/
        /// Iterative solution
        /// T.C = O(h) where h is the height of the tree
        /// S.C = O(1)
        /// </summary>
        /// <param name="root"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public Node SearchBST(Node root, int val)
        {
            var current = root;

            while (current != null)
            {
                if (val == current.Value)
                    return current;

                if (val < current.Value)
                    current = current.Left;
                else
                    current = current.Right;
            }

            return current!;
        }
    }
}
