using Algorithms.Sessions.Module2;

namespace Algorithms.Tests.Sessions.Module2
{
    public class Session2BinarySearchTests
    {
        private Session2BinarySearch _sut;

        public Session2BinarySearchTests()
        {
            _sut = new Session2BinarySearch();
        }

        [Theory]
        [InlineData(new[] { 5,  3, 6, 1, 9 }, 2, 20, 3)]
        public void CountPaintersToFillBoards_Returns_NumberOfPaintersToFillBoardsInAGivenTime(
            int[] boards, int unitTime, int totalTime, int expected)
        {
            
            var result = _sut.CountPaintersToFillBoards(boards, unitTime, totalTime);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 5, 3, 6, 1, 9 }, 2, 3, 27)]
        public void FindTimeToPaintBoard_Returns_NumberOfPaintersToFillBoardsInAGivenTime(
            int[] boards, int painters, int totalTime, int expected)
        {

            var result = _sut.FindTimeToPaintBoard(boards, painters, totalTime);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 1, 3, 5, 8, 10, 12, 17 }, 10, 2)]
        public void AggressiveCows_Returns_NumberOfPaintersToFillBoardsInAGivenTime(
            int[] stalls, int d, int expected)
        {

            var result = _sut.AggressiveCows(stalls, d);

            Assert.Equal(expected, result);
        }
    }
}
