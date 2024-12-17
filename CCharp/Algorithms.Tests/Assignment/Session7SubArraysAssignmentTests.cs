using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Assignment;

namespace Algorithms.Tests.Assignment
{
    public class Session7SubArraysAssignmentTests
    {
        [Theory]
        [InlineData(new int[] {3, 7, 90, 20, 10, 50, 40}, 3, 26)]
        [InlineData(new int[] {222, 482, 318, 341, 462, 191, 117, 129, 493, 473, 123, 106, 212, 
            214, 471, 446, 452, 299, 327, 39, 373, 386, 402, 333, 341, 79, 112, 257, 491, 33, 175, 67, 
            475, 388, 362, 249, 366, 38, 153, 287, 365, 375, 448, 355, 400, 117, 35, 84, 277, 323, 441, 
            338, 441, 200, 273, 315, 326, 71, 321, 217, 101, 364, 271, 252, 448, 300, 188 }, 40, 264)]
        public void LeastAvgSubArraySum_ShouldReturn_TheLeastAvgSubArraySum(int[] input, int k, long expected)
        {
            var sut = new Session7SubArraysAssignment();
            var actual = sut.LeastAvgSubArraySum(input, k);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 52, 
            7, 93, 47, 68, 26, 51, 44, 
            5, 41, 88, 19, 78, 38, 
            17, 
            13, 24, 74, 92, 
            5, 84, 27, 48, 49, 37, 59, 
            3, 56, 79, 26, 55, 60, 
            16, 83, 63, 40, 55, 
            9, 96, 29, 
            7, 22, 27, 74, 78, 38, 
            11, 65, 29, 52, 36, 21, 94, 46, 52, 47, 87, 33, 87, 70 }, 19, 10)]
        public void CountSwap_ShouldReturn_TheMinNumberOfSwapsToMoveElementsGreaterThanKFirst(int[] input, int k, long expected)
        {
            var sut = new Session7SubArraysAssignment();
            var actual = sut.CountSwap(input, k);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 52,
            7, 93, 47, 68, 26, 51, 44,
            5, 41, 88, 19, 78, 38,
            17,
            13, 24, 74, 92,
            5 /*19*/, 84, 27, 48, 49, 37, 59,
            3 /*26*/, 56, 79, 26, 55, 60,
            16 /*32*/, 83, 63, 40, 55,
            9 /*37*/, 96, 29,
            7 /*40*/, 22, 27, 74, 78, 38,
            11 /*46*/, 65, 29, 52, 36, 21, 94, 46, 52, 47, 87, 33, 87, 70 }, 19, 7)]
        [InlineData(new int[] { 31, 98, 58, 86, 36, 31,
            3, 22,
            4, 17, 51, 33, 56,
            7, 91,
            17, 59, 66, 54, 67, 55, 41, 58, 24, 100,
            1, 98, 68, 21, 33, 27, 67, 20, 66, 20, 100, 36, 89, 20,
            15,
            13, 26,
            11, 29, 99, 36, 39, 49, 74, 77, 54, 66, 30, 21,
            14, 18, 83, 72,
            10, 22, 53, 83, 60,
            9, 68, 56,
            9, 21, 77, 44, 45, 61, 97, 82, 35,
            16, 38, 95, 55,
            11, 46, 77, 25,
            3, 44 }, 18, 12)]
        [InlineData(new int[] {0}, 1000000000, 0)]
        public void MinSwapMoves_ShouldReturn_TheMinNumberOfSwapsToMoveElementsGreaterThanKFirst(int[] input, int k, long expected)
        {
            var sut = new Session7SubArraysAssignment();
            var actual = sut.MinSwapMoves(input, k);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] {6, 1, 4, 9, 6, 11, 12, 15 },  7, 4)]
        public void CountAllChocolate_ShouldReturn_TheMinNumberOfSwapsToMoveElementsGreaterThanKFirst(int[] input, int k, long expected)
        {
            var sut = new Session7SubArraysAssignment();
            var actual = sut.CountAllChocolate(input, k);
            Assert.Equal(expected, actual);
        }
    }
}
