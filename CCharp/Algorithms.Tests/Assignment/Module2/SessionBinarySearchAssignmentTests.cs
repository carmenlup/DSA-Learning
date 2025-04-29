using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Assignment.Module2;
using Algorithms.Sessions;
using Microsoft.Win32.SafeHandles;

namespace Algorithms.Tests.Assignment.Module2
{
    public class SessionBinarySearchAssignmentTests
    {
        private readonly Session2BinarySearchAssignment _sut;

        public SessionBinarySearchAssignmentTests()
        {
            _sut = new Session2BinarySearchAssignment();
        }

        [Theory]
        [InlineData(new[] { 5, 7, 7, 8, 8, 10 }, 8, new[] { 3, 4 })]
        [InlineData(new[] { 5, 7, 7, 8, 8, 10 }, 6, new[] { -1, -1 })]
        [InlineData(new[] { 5, 7, 7, 8, 8, 10, 10 }, 10, new[] { 5, 6 })]
        [InlineData(new[] { 5, 5, 7, 7, 8, 8, 10 }, 5, new[] { 0, 1 })]
        [InlineData(new int[] { }, 0, new[] { -1, -1 })]


        public void SearchRange_ShouldReturnFirsAndLastPosition_ForTarget_ThatHasHighestFrequency(int[] input,
            int target, int[] expected)
        {
            var result = _sut.SearchRange(input, target);

            Assert.Equal(expected[0], result[0]);
            Assert.Equal(expected[1], result[1]);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3, 1 }, 3)]
        [InlineData(new[] { 1, 2, 1, 3, 5, 6, 4 }, 6)]
        [InlineData(new[] { 1 }, 1)]
        [InlineData(new[] { 1, 2 }, 2)]
        [InlineData(new[] { 2, 1 }, 2)]
        [InlineData(new[] { 2, 1, 2 }, 2)]
        [InlineData(new[] { 4, 3, 2, 1 }, 4)]
        [InlineData(new[] { 1, 2, 1, 2, 1 }, 2)]
        public void FindPeakElement_ShouldReturnIndexOfPickElement_ForAGivenArray(int[] input, int expected)
        {

            var result = _sut.FindPeakElement(input);
            Assert.Equal(expected, result);
        }
    }
}
