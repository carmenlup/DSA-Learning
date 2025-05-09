using Algorithms.Sessions.Module2.StackAndQueue;

namespace Algorithms.Tests.Sessions.Module2.StacksAndQueues
{
    public class StackLTests
    {
        [Fact]
        public void Push_StackLNotFull_CanInsertElementOnTopOfTheStack()
        {
            // arrange
            var stack = new StackL();
            stack.Push(1);
            stack.Push(2);

            // act 
            var actual = stack.Push(3);

            // assert
            Assert.True(actual);
            Assert.Equal(2, stack.Top);
            Assert.Equal(3, stack.StackNodes.First.Value);
        }

        [Fact]
        public void Pop_StackLNotEmpty_ReturnElemFromTop()
        {
            // arrange
            var stack = new StackL();
            stack.Push(1);
            stack.Push(2);

            // act 
            var actual = stack.Pop();

            // assert
            Assert.Equal(1, stack.StackNodes.First.Value);
            Assert.Equal(0, stack.Top);
        }

        [Fact]
        public void Peek_StackLNotEmpty_ReturnElemFromTop()
        {
            // arrange
            var stack = new StackL();
            stack.Push(1);
            stack.Push(2);

            // act 
            var actual = stack.Peek();

            // assert
            Assert.Equal(stack.StackNodes.First.Value, actual);
            Assert.Equal(1, stack.Top);
        }

        [Fact]
        public void Peek_StackLEmpty_ReturnZero()
        {
            var stack = new StackL();
            // act 
            var actual = stack.Pop();

            // assert
            Assert.Equal(0, actual);
            Assert.Null(stack.StackNodes.First);
            Assert.Equal(-1, stack.Top);
        }

        [Fact]
        public void Pop_StackLEmpty_HeadValue()
        {
            var stack = new StackL();
            // act 
            var actual = stack.Pop();

            // assert
            Assert.Equal(0, actual);
            Assert.Equal(-1, stack.Top);
        }

        [Fact]
        public void IsEmpty_StackAEmpty_Validate()
        {
            // arrange
            var stack = new StackL();
            // act 
            var actual = stack.IsEmpty();

            // assert
            Assert.True(actual);
        }

        [Fact]
        public void IsEmpty_StackANotEmpty_Validate()
        {
            // arrange
            var stack = new StackL();
            stack.Push(1);
            stack.Push(2);
            // act 
            var actual = stack.IsEmpty();

            // assert
            Assert.False(actual);
        }

    }
}
