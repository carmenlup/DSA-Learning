using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Sessions.Module2;

namespace Algorithms.Tests.Sessions.Module2
{
    public class Session1BinarySearchTests
    {
        private Session1BinarySearch _sut;

        public Session1BinarySearchTests()
        {
            _sut = new Session1BinarySearch();
        }

        

        [Theory]
        [InlineData(new[] { 9, 2147483647, 2147483647 }, 9, 0)]
        public void BinarySearch_Return_IndexOfATarget(int[] input, int target, int expected)
        {
            var actual = _sut.BinarySearch(input, target);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { -5, -5, -3, 0, 0, 1, 5, 5, 5, 5, 5, 8, 10, 10, 15, }, 5, 6)]
        public void FindOccurence_Return_IndexOfFirstOccurenceOATarget(int[] input, int target, int expected)
        {
            var actual = _sut.FindOccurence(input, target);
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(new[] { 1, 2, 3 }, 0)]
        [InlineData(new[] { 1 }, 0)]
        [InlineData(new[] { 1, 2 }, 0)]
        [InlineData(new[] { 2, 1 }, 1)]
        [InlineData(new[] { 2, 1, 2 }, 1)]
        [InlineData(new[] { 4, 3, 2, 1 }, 3)]
        [InlineData(new[] { 4, 2, 1, 2, 9 }, 2)]
        public void FindMinima_ShouldReturn_IndexOfPickElement_ForAGivenArray(int[] input, int expected)
        {

            var result = _sut.FindMinima(input);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1, 0)]
        [InlineData(25, 5)]
        [InlineData(35, 5)]
        [InlineData(36, 6)]
        public void MySqrt_Return_SquareOfANaturalNumber(int x, int expected)
        {
            var actual = _sut.MySqrt(x);
            Assert.Equal(expected, actual);
        }
    }
}
