using Algorithms.Sessions.Module2.Tree;

namespace Algorithms.Sessions.Module2
{
    public class Session8TreeBasicsAndTraversal
    {
        #region Traversal
        private IList<int> _result = new List<int>();
        /// <summary>
        /// Easy- NLR
        /// 144. Binary Tree PreOrder Traversal
        /// https://leetcode.com/problems/binary-tree-preorder-traversal/
        /// T.C -> O(n) - where n = no of nodes
        /// S.C -> O(h) where h = height of tree
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> PreOrderTraverse(Node? root)
        {
            if (root == null) return _result;

            _result.Add(root.Value);

            PreOrderTraverse(root.Left);

            PreOrderTraverse(root.Right);

            return _result;
        }

        /// <summary>
        /// Easy - LNR
        /// 94. Binary Tree InOrder Traversal
        /// https://leetcode.com/problems/binary-tree-inorder-traversal/
        /// T.C -> O(n) - where n = no of nodes
        /// S.C -> O(h) where h = height of tree
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> InOrderTraverse(Node? root)
        {
            if (root == null) return _result;

            InOrderTraverse(root.Left);

            _result.Add(root.Value);

            InOrderTraverse(root.Right);

            return _result;
        }


        /// <summary>
        /// Easy - RLN
        /// 145. Binary Tree PostOrder Traversal
        /// https://leetcode.com/problems/binary-tree-postorder-traversal/
        /// T.C -> O(n) - where n = no of nodes
        /// S.C -> O(h) where h = height of tree
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> PostOrderTraverse(Node? root)
        {
            if (root == null) return _result;

            if (root.Left != null)
                PostOrderTraverse(root.Left);

            if (root.Right != null)
                PostOrderTraverse(root.Right);

            _result.Add(root.Value);

            return _result;
        }

        #endregion

        #region Level Order Traversal
        /// <summary>
        /// Medium
        /// 102. Binary Tree Level Order Traversal
        /// Source: // https://leetcode.com/problems/binary-tree-level-order-traversal/description/
        /// Solution:
        /// - use a queue to keep track of nodes at each level
        /// - for each level, iterate through the nodes, adding their values to the result list
        /// - enqueue their children for the next level
        /// - T.C -> O(h) - where h = height of the tree (in the worst case, we traverse all nodes in the tree)
        /// - S.C -> O(n) - where n = no of nodes at the last level (in the worst case, all nodes are at the last level)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<IList<int>> LevelOrder(Node? root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (root == null) return result;

            Queue<Node?> queue = new Queue<Node?>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                IList<int> currentLevel = new List<int>();

                for (int i = 0; i < levelSize; i++)
                {
                    Node? currentNode = queue.Dequeue();
                    currentLevel.Add(currentNode.Value);

                    if (currentNode.Left != null)
                        queue.Enqueue(currentNode.Left);
                    if (currentNode.Right != null)
                        queue.Enqueue(currentNode.Right);
                }

                result.Add(currentLevel);
            }

            return result;

        }
        #endregion

    }
}
