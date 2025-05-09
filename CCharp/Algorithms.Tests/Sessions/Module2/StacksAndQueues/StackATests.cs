using Algorithms.Sessions.Module2.StackAndQueue;

namespace Algorithms.Tests.Sessions.Module2.StacksAndQueues
{
    public class StackATests
    {
        [Fact]
        public void Push_StackANotFull_CanInsertElementOnTopOfTheStack()
        {
            // arrange
            var stack = new StackA(3);
            stack.Push(1);
            stack.Push(2);

            // act 
            var actual = stack.Push(3); 

            // assert
            Assert.True(actual);
            Assert.Equal(2, stack.Top);
            Assert.Equal(3, stack.StackNodes[stack.Top]);
        }

        [Fact]
        public void Push_StackAFull_CannotInsertElementOnTopOfTheStack()
        {
            // arrange
            var stack = new StackA(3);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            // act 
            var actual = stack.Push(4);

            // assert
            Assert.False(actual);
            Assert.Equal(2, stack.Top);
            Assert.Equal(3, stack.StackNodes[stack.Top]);
        }

        [Fact]
        public void Pop_StackANotEmpty_ReturnElemFromTop()
        {
            // arrange
            var stack = new StackA(2);
            stack.Push(1);
            stack.Push(2);

            // act 
            var actual = stack.Pop();

            // assert
            Assert.Equal(2, actual);
            Assert.Equal(0, stack.Top);
            Assert.Equal(1, stack.StackNodes[stack.Top]);
        }

        [Fact]
        public void Pop_StackAEmpty_ReturnZeroWhenRemoveAnElement()
        {
            var stack = new StackA(0);
            // act 
            var actual = stack.Pop();

            // assert
            Assert.Equal(0, actual);
            Assert.Equal(-1, stack.Top);
            Assert.Empty(stack.StackNodes);
        }

        [Fact]
        public void Peek_StackANotEmpty_ReturnElemFromTop()
        {
            // arrange
            var stack = new StackA(2);
            stack.Push(1);
            stack.Push(2);

            // act 
            var actual = stack.Peek();

            // assert
            Assert.Equal(stack.StackNodes[stack.Top], actual);
            Assert.Equal(1, stack.Top);
        }

        [Fact]
        public void Peek_StackLEmpty_ReturnZero()
        {
            var stack = new StackA(0);
            // act 
            var actual = stack.Pop();

            // assert
            Assert.Equal(0, actual);
            Assert.Equal(0,stack.StackNodes.Length);
            Assert.Equal(-1, stack.Top);
        }

        [Fact]
        public void IsFull_StackAFull_Validate()
        {
            // arrange
            var stack = new StackA(3);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            // act 
            var actual = stack.IsFull();

            // assert
            Assert.True(actual);
        }

        [Fact]
        public void IsFull_StackANotFull_Validate()
        {
            // arrange
            var stack = new StackA(3);
            stack.Push(1);
            stack.Push(2);
            // act 
            var actual = stack.IsFull();

            // assert
            Assert.False(actual);
        }

        [Fact]
        public void IsEmpty_StackAEmpty_Validate()
        {
            // arrange
            var stack = new StackA(3);
            // act 
            var actual = stack.IsEmpty();

            // assert
            Assert.True(actual);
        }

        [Fact]
        public void IsEmpty_StackANotEmpty_Validate()
        {
            // arrange
            var stack = new StackA(3);
            stack.Push(1);
            stack.Push(2);
            // act 
            var actual = stack.IsEmpty();

            // assert
            Assert.False(actual);
        }

    }
}
