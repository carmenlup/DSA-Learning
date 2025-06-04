
using Algorithms.Sessions.Module2;
using Algorithms.Sessions.Module2.Tree;

namespace Algorithms.Tests.Sessions.Module2
{
    public class Session8TreeBasicsAndTraversalTests
    {
        private Session8TreeBasicsAndTraversal _sut;
        private Node? _root = null;
        public Session8TreeBasicsAndTraversalTests()
        {
            _sut = new Session8TreeBasicsAndTraversal();
            _root = new Node(1)
            {
                Left = new Node(2)
                {
                    Left = new Node(4),
                    Right = new Node(5)
                },
                Right = new Node(3)
                {
                    Left = new Node(6)
                }
            };
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 4, 5, 3, 6 })]
        public void PreOrderTraverse_ShouldReturn_NodeTraversalNRL(int[] expected)
        {
            // act 
            var actual = _sut.PreOrderTraverse(_root, new List<int>());

            // assert
            Assert.Equal(actual, expected.ToList());
        }

        [Theory]
        [InlineData(new int[] { 4, 2, 5, 1, 6, 3 })]
        public void InOrderTraverse_ShouldReturn_NodeTraversalRNL(int[] expected)
        {
            // act 
            var actual = _sut.InOrderTraverse(_root);

            // assert
            Assert.Equal(actual, expected.ToList());
        }

        [Theory]
        [InlineData(new int[] { 4, 5, 2, 6, 3, 1 })]
        public void PostOrderTraverse_ShouldReturn_NodeTraversalRNL(int[] expected)
        {
            // act 
            var actual = _sut.PostOrderTraverse(_root);

            // assert
            Assert.Equal(actual, expected.ToList());
        }

        [Theory]
        [MemberData(nameof(TreeData))]
        public void LevelOrderOfBinaryTree_ShouldReturn_ArrayWithNodesOfEachLevel(Node? root, List<List<int>> expected)
        {
            // act 
            var actual = _sut.LevelOrder(root);

            // assert
            Assert.Equal(actual, expected);
        }

        public static IEnumerable<object[]> TreeData()
        {
            yield return new object[]
            {
                new Node(1)
                {
                    Left = new Node(2)
                    {
                        Left = new Node(4),
                        Right = new Node(5)
                    },
                    Right = new Node(3)
                    {
                        Left = new Node(6)
                    }
                },
                new List<List<int>>
                {
                    new List<int> { 1 },
                    new List<int> { 2, 3 },
                    new List<int> { 4, 5, 6 }
                }
            };
            yield return new object[]
            {
                new Node(1),
                new List<List<int>>
                {
                    new List<int> { 1 },
                }
            };
            yield return new object[]
            {
                null,
                new List<List<int>>{}
            };
        }

       
    }
}
