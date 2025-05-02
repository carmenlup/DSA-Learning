using Algorithms.Sessions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tests.Sessions
{
    public class Session5PrefixSumTest
    {
        //[Fact]
        [Theory]
        [MemberData(nameof(SumRangeData))]
        public void SumRangeBruteForce_Should_Return_AllSumForTheGivenQueries(int[] input, int[][] q, List<long> expected)
        {
            var sut = new Session5PrefixSum();

            var actual = sut.SumRangeBruteForce(input, q);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(SumRangeData))]
        public void SumRange_Should_Return_AllSumForTheGivenQueries(int[] input, int[][] q, List<long> expected)
        {
            var sut = new Session5PrefixSum();

            var actual = sut.SumRange(input, q);
            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> SumRangeData()
        {
            yield return new object[]
            {
                new int[] {-2, 0, 3, -5, 2, -1},
                new int[][]
                {
                    new int[] {0, 2},
                    new int[] {2, 5},
                    new int[] {0, 5}
                },
                new List<long> {1, -1, -3}
            };
            yield return new object[]
            {
                new int[] {-3, 6, 2, 4, 5, 2, 8, -9, 3, 1},
                new int[][]
                {
                    new int[] {4, 8},
                    new int[] {3, 7},
                    new int[] {1, 3},
                    new int[] {7, 7},
                    new int[] {3, 6},
                    new int[] {0, 4}
                },
                new List<long> {9, 10, 12, -9, 19, 14}
            };
        }


        [Theory]
        [InlineData(new int[] {-3, 2, 4, -1}, 1)]
        [InlineData(new int[] {-7, 1, 5, 2, -4, 3, 0}, 2)]
        [InlineData(new int[] { 1, 7, 3, 6, 5, 6 }, 3)]
        public void Equilibrium_Should_Count_EqualLeftSumAndRightSumOfAnIntegerArray(int[] input, int expected)
        {
            var sut = new Session5PrefixSum();

            var actual = sut.Equilibrium(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(CountEvenData))]
        public void CountEvenBruteForce_Should_Return_NumberOfEvenForA(int[] input, int[][] q, List<int> expected)
        {
            var sut = new Session5PrefixSum();

            var actual = sut.CountEvenBruteForce(input, q);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(CountEvenData))]
        public void CountEven_Should_Return_NumberOfEvenForA(int[] input, int[][] q, List<int> expected)
        {
            var sut = new Session5PrefixSum();

            var actual = sut.CountEven(input, q);
            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> CountEvenData()
        {
            yield return new object[]
            {
                new int[] {2, 4, 3, 7, 9, 8, 6, 3, 4, 9},
                new int[][]
                {
                    new int[] {4, 8},
                    new int[] {3, 9},
                    new int[] {2, 7},
                    new int[] {0, 4},
                },
                new List<int> {3, 3, 2, 2}
            };
            yield return new object[]
            {
                new int[] {1, 12, 3, 6, 9, 8, 20, 30},
                new int[][]
                {
                    new int[] {3, 7},
                    new int[] {1, 5},
                    new int[] {2, 4},
                    new int[] {0, 6}
                },
                new List<int> {4, 3, 1, 4}
            };
        }
    }
}
