using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tests.Assignment
{
    public class Session9TwoDimensionalArraysAssignment
    {
        public long MaxSumOfSubArayLengthK(int[] input, int k)
        {
            var n = input.Length;
            long sum = 0;
            long max = 0;
            var s = 0;
            var e = k - 1;
            for (var i = 0; i < k; i++)
            {
                sum += input[i];
            }
            max = sum;
            s++;
            e++;
            while (e < n)
            {
                sum = sum - input[s - 1] + input[e];
                if (max < sum)
                {
                    max = sum;
                }
                s++;
                e++;
            }

            return max;
        }

        public int FindValueInMatrix(int[][] matrix, int value)
        {
            var rows = matrix.GetLength(0);
            var cols = rows;
            var i = 0;
            var j = cols - 1;
            while (i < rows && j > 0)
            {
                if (matrix[i][ j] == value)
                {
                    return 1;
                }

                if (matrix[i][ j] > value)
                {
                    j--;
                }
                if (matrix[i][ j] < value)
                {
                    i++;
                }
            }
            return 0;
        }
    }
}
