using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Sessions;

namespace Algorithms.Tests.Sessions
{
    public class Session6SubArraysTests
    {
        [Theory]
        [InlineData(new int[] {4, 1, 2, 3, -1, 6, 9, 8, 12}, 2, 4, new int[] {2, 3, -1})]
        [InlineData(new int[] { 4, 1, 2, 3, -1, 6, 9, 8, 12 }, 4, 7, new int[] { -1, 6, 9, 8 })]
        [InlineData(new int[] { 4, 1, 2, 3, -1, 6, 9, 8, 12 }, 1, 6, new int[] { 1, 2, 3, -1, 6, 9 })]

        public void PrintSubArrayIndex_ShouldReturn_SubArrayFromIndexSToE(int[] input, int s, int e, int[] expected)
        {
            var sut = new Session6SubArrays();
            var actual = sut.PrintSubArrayIndex(input, s, e);
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(new int[] { 4, 1, 2, 3, -1, 6, 9, 8, 12 }, 2, 3, new int[] { 2, 3, -1 })]
        [InlineData(new int[] { 4, 1, 2, 3, -1, 6, 9, 8, 12 }, 4, 4, new int[] { -1, 6, 9, 8 })]
        [InlineData(new int[] { 4, 1, 2, 3, -1, 6, 9, 8, 12 }, 1, 6, new int[] { 1, 2, 3, -1, 6, 9 })]

        public void PrintSubArrayOfLengthLFromStartIndex_ShouldReturn_SubArrayFromIndexLToS(int[] input, int s, int e,
            int[] expected)
        {
            var sut = new Session6SubArrays();
            var actual = sut.PrintSubArrayOfLengthLFromStartIndex(input, s, e);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 4, 1, 2, 3, -1, 6, 9, 8, 12 }, 45)]
        [InlineData(new int[] { 4, 1, 2, 3 }, 10)]
        [InlineData(new int[] { 1 }, 1)]

        public void CountSubArraysOfAnArrayBruteForce_ShouldReturn_TotalNumberOfSubArrays(int[] input, int expected)
        {
            var sut = new Session6SubArrays();
            var actual = sut.CountSubArraysOfAnArrayBruteForce(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 4, 1, 2, 3, -1, 6, 9, 8, 12 }, 45)]
        [InlineData(new int[] { 4, 1, 2, 3 }, 10)]
        [InlineData(new int[] { 1 }, 1)]

        public void CountSubArraysOfAnArray_ShouldReturn_TotalNumberOfSubArrays(int[] input, int expected)
        {
            var sut = new Session6SubArrays();
            var actual = sut.CountSubArraysOfAnArray(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(AllSubArraysData))]

        public void PrintAllSubArrays_ShouldReturn_AllSubArrays(int[] input, List<List<int>> expected)
        {
            var sut = new Session6SubArrays();
            var actual = sut.PrintAllSubArrays(input);
            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> AllSubArraysData()
        {
            yield return new object[]
            {
                new int[] {1},
                new List<List<int>> {new List<int> {1}}

            };
            yield return new object[]
            {
                new int[] {1, 2, 3},
                new List<List<int>>
                {
                    new List<int> {1},
                    new List<int> {1, 2},
                    new List<int> {1, 2, 3},
                    new List<int> {2},
                    new List<int> {2, 3},
                    new List<int> {3}
                }
            };
        }

        [Theory]
        [InlineData(new int[] { 1 }, new long[] {1})]
        [InlineData(new int[] { 2, 8, -1, 4 }, new long[] { 2, 10, 9, 13, 8, 7, 11, -1, 3, 4 })]
        public void PrintSumsOfAllSubArraysBruteForce_ShouldReturn_SumOfEachSubArrayOfAGivenArray(int[] input, long[] expected)
        {
            var sut = new Session6SubArrays();
            var actual = sut.PrintSumsOfAllSubArraysBruteForce(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1 }, new long[] { 1 })]
        [InlineData(new int[] { 2, 8, -1, 4 }, new long[] { 2, 10, 9, 13, 8, 7, 11, -1, 3, 4 })]
        public void PrintSumsOfAllSubArraysPrefixSum_ShouldReturn_SumOfEachSubArrayOfAGivenArray(int[] input, long[] expected)
        {
            var sut = new Session6SubArrays();
            var actual = sut.PrintSumsOfAllSubArraysPrefixSum(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 3, 8, 4, 7, 9, 4 , 3, 2, 10, 6}, 3, new long[] { 7, 16, 20, 23, 25, 35, 41 })]
        public void PrintAllSubArraySumStartIndex_ShouldReturn_SumOfEachSubArrayOfAGivenArrayFromIndexS(int[] input, int s, long[] expected)
        {
            var sut = new Session6SubArrays();
            var actual = sut.PrintAllSubArraySumStartIndex(input, s);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1 }, new long[] { 1 })]
        [InlineData(new int[] { 3, 2, -1 }, new long[] { 3, 5, 4, 2, 1, -1})]
        public void PrintAllSubArraySum_ShouldReturn_SumOfEachSubArrayOfAGivenArray(int[] input, long[] expected)
        {
            var sut = new Session6SubArrays();
            var actual = sut.PrintAllSubArraySum(input);
            Assert.Equal(expected, actual);
        }
    }
}
