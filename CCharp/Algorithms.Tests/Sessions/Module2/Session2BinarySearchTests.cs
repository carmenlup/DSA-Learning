using Algorithms.Sessions.Module2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
