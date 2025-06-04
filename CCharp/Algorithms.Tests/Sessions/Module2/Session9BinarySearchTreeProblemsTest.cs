
using Algorithms.Sessions.Module2;
using Algorithms.Sessions.Module2.Tree;

namespace Algorithms.Tests.Sessions.Module2
{
    public class Session9BinarySearchTreeProblemsTest
    {
        private Session9BinarySearchTreeProblems _sut;
        public Session9BinarySearchTreeProblemsTest()
        {
            _sut = new Session9BinarySearchTreeProblems();
        }

        [Fact]
        public void SearchRecursive_BinaryTreeAndValueExist_NodeWithGivenValue()
        {
            // arrange
            var head = new Node(4);
            head.Left = new Node(2);
            head.Right = new Node(7);
            head.Left.Left = new Node(1);
            head.Right.Right = new Node(3);

            // act 
            var actual = _sut.SearchRecursive(head, 2);

            // assert
            Assert.Equal(2, actual.Value);
        }

        [Fact]
        public void SearchRecursive_BinaryTreeAndValueNotExist_Null()
        {
            // arrange
            var head = new Node(4);
            head.Left = new Node(2);
            head.Right = new Node(7);
            head.Left.Left = new Node(1);
            head.Right.Right = new Node(3);

            // act 
            var actual = _sut.SearchRecursive(head, 5);

            // assert
            Assert.Null(actual);
        }

        [Fact]
        public void SearchBST_BinaryTreeAndValueExist_NodeWithGivenValue()
        {
            // arrange
            var head = new Node(4);
            head.Left = new Node(2);
            head.Right = new Node(7);
            head.Left.Left = new Node(1);
            head.Right.Right = new Node(3);

            // act 
            var actual = _sut.SearchBST(head, 2);

            // assert
            Assert.Equal(2, actual.Value);
        }

        [Fact]
        public void SearchBST_BinaryTreeAndValueNotExist_Null()
        {
            // arrange
            var head = new Node(4);
            head.Left = new Node(2);
            head.Right = new Node(7);
            head.Left.Left = new Node(1);
            head.Right.Right = new Node(3);

            // act 
            var actual = _sut.SearchBST(head, 5);

            // assert
            Assert.Null(actual);
        }
    }
}
