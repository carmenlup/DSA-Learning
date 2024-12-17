using Algorithms.Assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tests.Assignment
{
    public class Session9TwoDimensionalArraysAssignmentTests
    {
        [Fact]
       /* [InlineData(new int[9][]
        {
            new int[] {-37,-15,-15,-8,9,17,41,45,48},
            new int[] {-17,2,5,26,26,32,42,45,50},
            new int[] {-8,3,16,36,41,46,47,50,50},
            new int[] {0,13,19,45,45,49,49,50,50},
            new int[] {0,34,42,49,49,50,50,50,50},
            new int[] {2,34,49,50,50,50,50,50,50}, 
            new int[] {9,44,50,50,50,50,50,50,50},
            new int[] { 19, 48, 50, 50, 50, 50, 50, 50, 50 },
            new int[] { 20, 50, 50, 50, 50, 50, 50, 50, 50 }
        }, 7, 0)]*/
        public void CountAllChocolate_ShouldReturn_TheMinNumberOfSwapsToMoveElementsGreaterThanKFirst()
        {
            var sut = new Session9TwoDimensionalArraysAssignment();

            var test = new int[9][]
            {
                new int[9] {-37, -15, -15, -8, 9, 17, 41, 45, 48},
                new int[9] {-17, 2, 5, 26, 26, 32, 42, 45, 50},
                new int[] {-8, 3, 16, 36, 41, 46, 47, 50, 50},
                new int[] {0, 13, 19, 45, 45, 49, 49, 50, 50},
                new int[] {0, 34, 42, 49, 49, 50, 50, 50, 50},
                new int[] {2, 34, 49, 50, 50, 50, 50, 50, 50},
                new int[] {9, 44, 50, 50, 50, 50, 50, 50, 50},
                new int[] {19, 48, 50, 50, 50, 50, 50, 50, 50},
                new int[] {20, 50, 50, 50, 50, 50, 50, 50, 50}
            };
            var actual = sut.FindValueInMatrix(test, -50);
            Assert.Equal(0, actual);
        }


       [Fact]
       public void MyString_test()
       {
            // 5 \n
            // 1 2 3 4 5\n
            // 6 7 8 9 10\n
            // 11 12 13 14 15\n
            var input = "5\n1 2 3 4 5\n6 7 8 9 10\n11 12 13 14 15\n16 17 18 19 20\n21 22 23 24 25";
            var inputString = input.Split('\n');
            var n = int.Parse(inputString[0]);
            var matrix = new int[n][];
            for (var i = 0; i < n; i++)
            {
                matrix[i] = inputString[i + 1].Split(' ').Select(int.Parse).ToArray();
            }
            var sut = new Session9TwoDimensionalArraysAssignment();
            var actual = sut.FindValueInMatrix(matrix, 5);
            Assert.Equal(1, actual);
        }


    }
}
