using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sessions
{
    public class Session5PrefixSum
    {
        /// <summary>
        /// 303. Range Sum Query - Immutable
        /// Easy
        /// https://leetcode.com/problems/range-sum-query-immutable/
        /// Solution:
        ///     1. iterate over all queries
        ///     2. iterate over the array foreach query to find the sum
        ///     3. return an array with all sums that meet the criteria
        /// T.C = O(N*Q)
        /// S.C = O(1)
        /// </summary>
        /// <param name="input">N length array of integers</param>
        /// <param name="q">List of Q numbers of queries</param>
        /// <returns></returns>
        public List<long> SumRangeBruteForce(int[] input, int[][] q)
        {
            var result = new List<long>();
            for (int i = 0; i < q.Length; i++) // O(N)
            {
                var st = q[i][0];
                var end = q[i][1];

                // sum must be long to avoid StackOverflow exception
                long sum = 0;
                for (int j = st; j <= end; j++) // O(Q)
                {
                    sum += input[j];
                }
                result.Add(sum);
            }

            return result;
        }

        #region leetcode 
        ////public class NumArray
        ////{

        ////    int[] arr;
        ////    public NumArray(int[] nums)
        ////    {
        ////        arr = new int[nums.Length];
        ////        arr[0] = nums[0];
        ////        for (var i = 1; i < nums.Length; i++)
        ////            arr[i] += arr[i - 1] + nums[i];
        ////    }

        ////    public int SumRange(int left, int right)
        ////    {
        ////        int sum = 0;

        ////        if (left == 0)
        ////            sum = arr[right];
        ////        else
        ////            sum = arr[right] - arr[left - 1];

        ////        return sum;
        ////    }
        ////}
        #endregion

        /// <summary>
        /// 303. Range Sum Query - Immutable
        /// Easy
        /// https://leetcode.com/problems/range-sum-query-immutable/
        /// Solution: Prefix Sum
        /// T.C = O(N + Q)
        /// S.C = O(N)
        /// </summary>
        /// <param name="input"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public List<long> SumRange(int[] input, int[][] q)
        {
            var result = new List<long>();

            // create prefix sum
            var pSum = new long[input.Length];
            pSum[0] = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                pSum[i] += pSum[i - 1] + input[i];
            }

            for (int i = 0; i < q.Length; i++) // O(N)
            {
                var st = q[i][0];
                var end = q[i][1];

                // sum must be long to avoid StackOverflow exception
                long sum = 0;
                if (st == 0)
                    sum = pSum[end];
                else
                {
                    sum = pSum[end] - pSum[st -1];
                }
                //for (int j = st; j <= end; j++) // O(Q)
                //{
                //    sum += nums[j];
                //}
                result.Add(sum);
            }

            return result;
        }

        /// <summary>
        /// Problem: For an array of integer calculate sum from left and right and count
        ///          all that are equal
        /// Source to practice: https://app.codility.com/programmers/lessons/3-time_complexity/tape_equilibrium/
        /// Source implementation options described in detail: https://www.geeksforgeeks.org/find-element-array-sum-left-array-equal-sum-right-array/
        /// Practice similar problems 
        ///     1: https://leetcode.com/problems/find-pivot-index/
        ///     2: https://leetcode.com/problems/find-the-middle-index-in-array/
        /// Sol:
        ///     1. Calculate pSum
        ///     2. find leftSum and rightSum for each i
        ///     3. count if leftSum = rightSum
        ///
        /// T.C = O(N + N) = O(N)
        /// S.C = O(N)
        /// </summary>
        /// <param name="nums">Integer array of length N</param>
        /// <returns></returns>
        public int Equilibrium(int[] nums)
        {
            long[] pSum = new long[nums.Length];

            var n = nums.Length;
            pSum[0] = nums[0];
            for (int i = 1; i < n; i++)
            {
                pSum[i] = pSum[i - 1] + nums[i];
            }

            int count = 0;
            long left;
            long right;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                    left = 0;
                else
                    left = pSum[i - 1];

                right = pSum[n - 1] - pSum[i];

                if (left == right)
                    count++;
            }

            return count;
        }

        /// <summary>
        /// Count even numbers in ranges for a given array
        /// Source Inplementation explained for a range only
        ///     https://www.geeksforgeeks.org/count-number-even-odd-elements-array/
        /// T.C = O(n * q), where n is the length of the array and q - number of queries
        /// S.C = O(q)
        /// </summary>
        /// <param name="input"></param
        /// <param name="q">
        ///     Two dimensional array of q queries with
        ///     left and right values that represents the margins of the intervals
        /// </param>
        /// <returns></returns>
        public List<int> CountEvenBruteForce(int[] input, int[][] q)
        {
            var result = new List<int>();
            for (var i = 0; i < q.Length; i++)
            {
                var count = 0;
                var left = q[i][0];
                var right = q[i][1];
                for (var j = left; j <= right; j++)
                {
                    if (input[j] % 2 == 0)
                        count++;
                }
                result.Add(count);
            }

            return result;
        }

        /// <summary>
        /// Count even number of all subarrays sum in given array
        /// Source: https://leetcode.com/problems/count-of-range-sum/
        /// Source: https://leetcode.com/problems/count-number-of-nice-subarrays/
        /// T.C = O(n + q), where n is the length of the array and q - number of queries
        /// S.C = O(q)
        /// </summary>
        /// <param name="input"></param
        /// <param name="q">
        ///     Two dimensional array of q queries with
        ///     left and right values that represents the margins of the intervals
        /// </param>
        /// <returns></returns>
        public List<int> CountEven(int[] input, int[][] q)
        {
            var result = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0)
                    input[i] = 1;
                else
                {
                    input[i] = 0;
                }
            }

            int[] pSum = new int[input.Length];
            var n = input.Length;
            pSum[0] = input[0];
            for (int i = 1; i < n; i++)
            {
                pSum[i] = pSum[i - 1] + input[i];
            }

            var count = 0;
            for (int i = 0; i < q.Length; i++)
            {
                var left = q[i][0];
                var right = q[i][1];
                
                if (left == 0)
                    count = pSum[right];
                else
                {
                    count = pSum[right] - pSum[left - 1];
                }
                result.Add(count);
            }

            return result;
        }
    }
}
