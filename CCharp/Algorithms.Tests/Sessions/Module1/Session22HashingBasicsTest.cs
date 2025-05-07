using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Sessions.Module1;

namespace Algorithms.Tests.Sessions.Module1
{
    public class Session22HashingBasicsTest
    {
        private Session22HashingBasics _sut;

        public Session22HashingBasicsTest()
        {
            _sut = new Session22HashingBasics();
        }

        [Theory]
        [InlineData(new[] { 2, 6, 3, 8, 2, 8, 2, 3, 8, 10, 6  }, new int[] { 2, 8, 3, 5 }, new int[] { 3, 3, 2, 0 })]
        public void FrequencyCount_ShouldReturn_TheFrequencyCount(int[] arr, int[] students, int[] expected)
        {
            var result = _sut.FrequencyCount(arr, students);
            Assert.Equal(expected, result);
        }

        // add tests for DistinctElements method
        [Theory]
        [InlineData(new[] { 1, 2, 3}, 3)]
        [InlineData(new[] { 1, 2, 3, 1, 2, 1, 4, 3 }, 4)]
        public void DistinctElements_Should_CountTheDistinctElements(int[] arr, int expected)
        {
            var result = _sut.DistinctElements(arr);
            Assert.Equal(expected, result);
        }

        [InlineData("ABDEFGABEF", 6)]
        [InlineData("BBBB", 1)]
        [InlineData("", 0)]
        [InlineData("pwwkew", 4)]
        public void LengthOfLongestSubstring_ShouldReturn_TheLengthOfLongestSubsting(string height, int expected)
        {
            var result = _sut.LengthOfLongestSubstring(height);

            Assert.Equal(expected, result);
        }

        #region additional problems

        [Theory]
        [InlineData(new[] { 1, 2, 3, 2 }, 4)]
        [InlineData(new[] { 1, 1, 1, 1, 2, 3 }, 5)]
        [InlineData(new[] { 1, 1, 1, 1, 1 }, 0)]
        public void SumOfUnique_ShouldReturn_TheSumOfUnique(int[] arr, int expected)
        {
            var result = _sut.SumOfUnique(arr);
            Assert.Equal(expected, result);
        }

        #endregion


    }
}
