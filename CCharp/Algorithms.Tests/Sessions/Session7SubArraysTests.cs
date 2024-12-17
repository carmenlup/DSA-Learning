using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Sessions;

namespace Algorithms.Tests.Sessions
{
    public class Session7SubArraysTests
    {

        [Theory]
        [InlineData(new int[] { 3, 4, 2 }, 31)]
        public void TotalSubArraySum_ShouldReturn_TheSUmOfAllSumOfSubArrays(int[] input, long expected)
        {
            var sut = new Session7SubArrays();
            var actual = sut.PrintTotalSumOfSubArrays(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 4, 3, 2, 6, 1 }, 3, 11, true)]

        [InlineData(new int[] { 4, 3, 1, 6, 1 }, 3, 11, false)]
        public void SubArrayWithGivenSum_ShouldReturn_TheSUmOfAllSumOfSubArrays(int[] input, int B, int C, bool expected)
        {
            var sut = new Session7SubArrays();
            var actual = sut.SubArrayWithGivenSum(input, B, C);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 6, 7, 8, 2 }, 2, 15)]

        public void MaxSubArraySumOfLengthK_ShouldReturn_TheSUmOfAllSumOfSubArrays(int[] input, int B, long expected)
        {
            var sut = new Session7SubArrays();
            var actual = sut.MaxSubArraySumOfLengthK(input, B);
            Assert.Equal(expected, actual);
        }
    }
}
