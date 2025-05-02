using Algorithms.Sessions.Module2;

namespace Algorithms.Tests.Sessions.Module2
{
    public class Session3PracticeBinarySearchTests
    {
        private Session3PracticeBinarySearch _sut;

        public Session3PracticeBinarySearchTests()
        {
            _sut = new Session3PracticeBinarySearch();
        }

        [Theory]
        [InlineData(new[] { 1, 1, 2, 3, 3, 4, 4, 8, 8 }, 2)]
        [InlineData(new[] { 3, 3, 7, 7, 10, 11, 11 }, 10)]
        public void SingleNonDuplicate_ShouldReturn_TheSingleElement_ForAGivenArray(int[] input, int expected)
        {
            var result = _sut.SingleNonDuplicate(input);
            Assert.Equal(expected, result);
        }


        [Theory]
        [InlineData(new[] { 4, 5, 6, 7, 0, 1, 2 }, 0, 4)]
        [InlineData(new[] { 4, 5, 6, 7, 0, 1, 2 }, 3, -1)]
        [InlineData(new[] { 1 }, 0, -1)]
        [InlineData(new[] { 3, 5, 1 }, 3, 0)]
        [InlineData(new[] { 3, 5, 1 }, 4, -1)]
        [InlineData(new[] { 5, 1, 3 }, 5, 0)]
        [InlineData(new[] { 5, 1, 3 }, 3, 2)]
        [InlineData(new[] { 1, 3 }, 3, 1)]
        [InlineData(new[] { 4, 5, 6, 7, 8, 1, 2, 3 }, 8, 4)]
        [InlineData(new[] { 5, 1, 2, 3, 4 }, 1, 1)]
        public void Search_ReturnIndexOfItem_ForAnArrayOfValues(int[] input, int searchValue, int expected)
        {
            var result = _sut.Search(input, searchValue);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 1, 3 }, new[] {2}, 2)]
        [InlineData(new[] { 1, 2 }, new[] { 3, 4 }, 2.5)]
        public void FindMedianSortedArrays_Return_MedianOfTwoSortedArray(int[] input1, int[] input2, double expected)
        {
            var result = _sut.FindMedianSortedArrays(input1, input2);
            Assert.Equal(expected, result);
        }

    }
}
