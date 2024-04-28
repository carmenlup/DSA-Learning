using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sessions
{
    public class Session6SubArrays
    {
        /// <summary>
        /// Initial problem: print a subArray from index start to index end
        /// T.C -> O(n)
        /// S.C -> O(n) - this is O(1) for only printing. I created ana array for UT
        /// </summary>
        /// <param name="array"></param>
        /// <param name="s"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public int[] PrintSubArrayIndex(int[] array, int s, int e)
        {
            var result = new int[e - s + 1];
            var idx = 0;
            for (int i = s; i <= e; i++)
            {
                result[idx] = array[i];
                idx++;
            }

            return result;
        }

        /// <summary>
        /// Initial problem: print a subArray or length l from start index
        /// T.C -> O(n)
        /// T.C -> O(n) - this is O(1) for only printing. I created ana array for UT
        /// </summary>
        /// <param name="array"></param>
        /// <param name="s"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public int[] PrintSubArrayOfLengthLFromStartIndex(int[] array, int s, int l)
        {
            // l = end - s + 1 ->  length of interval 
            var end = l + s - 1;
            var result = new int[l];
            var idx = 0;
            for (int i = s; i <= end; i++)
            {
                result[idx] = array[i];
                idx++;
            }

            return result;
        }

        /// <summary>
        /// Problem count total sub-arrays of a given array
        /// Solution: brute force
        ///     - iterate over the array 2 times to count the sub-arrays
        /// T.C -> O(n)
        /// S.C -> O(1)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int CountSubArraysOfAnArrayBruteForce(int[] input)
        {
            var count = 0;
            for (var i = 0; i < input.Length; i++)
            {
                for (var j = i; j < input.Length; j++)
                {
                    count++;
                }
            }

            return count;
        }

        /// <summary>
        /// Total sub-arrays of a given array
        /// Solution 2:
        ///     The problem can be solved in O(1) time complexity based on the next observation:
        ///     Example: arr[n] - n has n elements
        ///         - starting from index 0 we can construct n sub-arrays with 1, 2, 3, ... n elements
        ///         - starting to index 1 we can construct n - 1 sub-arrays with 1, 2, 3, ..., n-1 elements
        ///         - ...
        ///         - starting from index n - 1 (last index of the array) we can construct 1 sub-array of 1 element
        ///         => Total numbers of the possible sub-arrays will be: n + (n-1) + ... + 1 = n * (n + 1) / 2
        /// T.C = O(1)
        /// S.C = O(1)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int CountSubArraysOfAnArray(int[] input)
        {
            var n = input.Length;
            return n * (n + 1) / 2;
        }

        /// <summary>
        /// Problem - Print all sub-arrays of an array
        /// T.C -> O(n^3)
        /// S.C -> O(n^2)
        ///     - iterate over array w times to find start and end index
        ///     - iterate from start to end index and add the subArray to the result
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<List<int>> PrintAllSubArrays(int[] input)
        {
            var n = input.Length;
            var result = new List<List<int>>();
            for (var s = 0; s < n; s++)
            {
                for (var e = s; e < input.Length; e++)
                {
                    var subArray = new List<int>();
                    for (int i = s; i <= e; i++)
                        subArray.Add(input[i]);

                    result.Add(subArray);
                }
            }

            return result;
        }

        /// <summary>
        /// Print each sub-arrays sum for a given array
        /// Solution: Brute force
        ///     - iterate over array w times to find start and end index
        ///     - iterate from start to end index and calculate the sum
        /// T.C = O(n^3)
        /// S.C = O(n)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public long[] PrintSumsOfAllSubArraysBruteForce(int[] input)
        {
            var n = input.Length;
            var totalSubArrays = n * (n + 1) / 2;
            var result = new long[totalSubArrays];
            var idx = 0;
            for (var s = 0; s < n; s++)
            {
                for (var e = s; e < input.Length; e++)
                {
                    var sum = 0;
                    for (int i = s; i <= e; i++)
                        sum += input[i];

                    result[idx] = sum;
                    idx++;
                }
            }

            return result;
        }

        /// <summary>
        /// Print each sub-arrays sum for a given array
        /// Solution: Using Prefix Sum
        ///     - calculate prefix sum
        ///     - iterate over array w times to find start and end index
        ///     - calculate the sum using prefix sum (instead to iterate again)
        /// T.C = O(n^2)
        /// S.C = O(n)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public long[] PrintSumsOfAllSubArraysPrefixSum(int[] input)
        {
            var n = input.Length;
            var totalSubArrays = n * (n + 1) / 2;
            var result = new long[totalSubArrays];

            //calculate prefix sum
            long[] pSum = new long[n];
            pSum[0] = input[0];
            for (var i = 1; i < n; i++)
            {
                pSum[i] = pSum[i - 1] + input[i];
            }

            var idx = 0;
            for (var s = 0; s < n; s++)
            {
                for (var e = s; e < n; e++)
                {
                    // calculate sum from s to e using pSum
                    long sum = 0;
                    if (s == 0)
                        sum = pSum[e];
                    else sum = pSum[e] - pSum[s -1];

                    result[idx] = sum;
                    idx++;
                }
            }

            return result;
        }

        /// <summary>
        /// Print all sub-arrays sum starting at a given index
        /// T.C = O(n)
        /// S.C = O(n)
        /// </summary>
        /// <param name="input"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public long[] PrintAllSubArraySumStartIndex(int[] input, int s)
        {
            int n = input.Length;
            int sum = 0;
            var totalSubArrays = n - s;

            long[] result = new long[totalSubArrays];
            int idx = 0;
            for (var e = s; e < n; e++)
            {
                sum += input[e];
                result[idx] = sum;
                idx++;
            }

            return result;
        }

        /// <summary>
        /// Print all sub-arrays sums starting from a index
        /// T.C = O(n^2)
        /// S.C = O(n)
        /// </summary>
        /// <param name="input"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public long[] PrintAllSubArraySum(int[] input)
        {
            int n = input.Length;
            var totalSubArrays = n * (n + 1) / 2;
           
            long[] result = new long[totalSubArrays];
            int idx = 0;
            for (int s = 0; s < n; s++)
            {
                int sum = 0;
                for (var e = s; e < n; e++)
                {
                    sum += input[e];
                    result[idx] = sum;
                    idx++;
                }
            }

            return result;
        }

    }
}
