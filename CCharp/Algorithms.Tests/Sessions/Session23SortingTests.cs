using Algorithms.Sessions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tests.Sessions
{
    public class Session23SortingTests
    {
        private Session23Sorting _sut;
        public Session23SortingTests()
        {
            _sut = new Session23Sorting();
        }

        [Theory]
        [InlineData(310, 103)]
        [InlineData(-7605, -7650)]
        [InlineData(0, 0)]
        [InlineData(63, 36)]
        [InlineData(4099, 4099)]
        [InlineData(1000000000000000, 1000000000000000)]
        [InlineData(10000000000000001, 10000000000000001)]
        public void SmalestNumber_GivenArray_ReturnsSmalestNumber(long n, long expected)
        {
            var max = long.MaxValue;
            // Act
            var actual = _sut.SmalestNumber(n);

            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(new int[] { 1, 2, 4, 3, 1, 4, 5, 1, 2 }, 
            new int[] { 1, 1, 1, 2, 2, 3, 4, 4, 5 })]
        public void SmalestNumberPositiveDigits_GivenArray_ReturnsSmalestNumber(int[] input, int[] result)
        {
            // Act
            var actual = _sut.SmalestNumberPositiveDigits(input);

            // Assert
            Assert.Equal(result, actual);
        }
        [Theory]
        [InlineData(
            new[] { 1, 2, 3},
            new[] { 2, 5, 6 },
            new[] { 1, 2, 2, 3, 5, 6 })]
        [InlineData(
            new[] { 0, 2 },
            new[] { 0, 1 },
            new[] { 0, 0, 1, 2 })]
        [InlineData(
            new[] { 0, 0, 3 },
            new[] { -1, 1, 1, 1, 2, 3 },
            new[] { -1, 0, 0, 1, 1, 1, 2, 3, 3 })]
        [InlineData(
            new int[] {},
            new[] { 1, 2, 3, 4, 5 },
            new[] { 1, 2, 3, 4, 5 })]
        [InlineData(
            new int [] { },
            new[] { 1 },
            new[] { 1 })]
        public void MergeTwoArrays2_ShouldReturnMergedArray_AndKeepIndexItem(
            int[] list1, int[] list2, int[] expected)
        {
            var actual = _sut.MergeAllImboxEmails(list1, list2);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(
            new[] { 1, 2, 3, 2, 5, 6 }, 
            new[] { 1, 2, 2, 3, 5, 6 })]
        [InlineData(
            new[] { 0, 0, 2, 1 }, 
            new[] { 0, 0, 1, 2 })]
        [InlineData(
            new[] { -1, 0, 0, 1, 1, 1, 3, 2, 3 }, 
            new[] { -1, 0, 0, 1, 1, 1, 2, 3, 3 })]
        [InlineData(
            new[] { 1, 2, 3, 4, 5 },
            new[] { 1, 2, 3, 4, 5 })]
        [InlineData(
            new[] { 1 }, 
            new[] { 1 })]
        public void SortArray_ShouldReturnMergedArray_AndKeepIndexItem(
            int[] list, int[] expected)
        {
            _sut.SortArray(list);
            Assert.Equal(expected, list);
        }
    }
}
