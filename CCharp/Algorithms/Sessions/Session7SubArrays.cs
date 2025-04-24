using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sessions
{
    public class Session7SubArrays
    {
        /// <summary>
        /// Print all sub-arrays sums starting from a index
        /// T.C = O(n^2)
        /// S.C = O(n)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string PrintAllSubArraysSum(int[] input)
        {
            var result = new StringBuilder();
            
            for (var s = 0; s < input.Length; s++)
            {
                var sum = 0;
                for (var e = s; e < input.Length; e++)
                {
                    sum += input[e];
                    result.Append(sum + " ");
                }
                
            }

            return result.ToString();
        }

        /// <summary>
        /// Print total sum of all sub arrays of a given array
        /// T.C = O(n^2)
        /// S.C = O(1)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public long PrintTotalSumOfSubArrays(int[] input)
        {
            var totalSum = 0;

            for (var s = 0; s < input.Length; s++)
            {
                var sum = 0;
                for (var e = s; e < input.Length; e++)
                {
                    sum += input[e];
                    totalSum += sum;
                }
            }

            return totalSum;
        }

        /// <summary>
        /// Print total sum of all sub arrays of a given array
        /// Solution: Using Contribution technique
        /// 1. we will count the appearance of each element in the subArray
        /// T.C = O(n)
        /// S.C = O(1)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public long PrintTotalSumOfSubArraysByContribution(int[] input)
        {
            var totalSum = 0;

            for (var i = 0; i < input.Length; i++)
            {
                var sum = 0;
                var occurance = (i + 1) * (input.Length - i);
                var cotribution = input[i] * occurance;
                sum += input[i] * cotribution;
                totalSum += sum;
                /*var sum = 0;
                for (var e = s; e < input.Length; e++)
                {
                    sum += input[e];
                    totalSum += sum;
                }*/
            }

            return totalSum;
        }

        /// <summary>
        /// Check if sum of sub arrays have sum C
        /// Conclusion - this method will not give the minimum because we
        /// add in plus movements for the first numbers
        /// - the solution is to iterate from the end of the array
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="C"></param>
        /// <returns></returns>
        public bool SubArrayWithGivenSum(int[] A, int B, int C)
        {
            var n = A.Length;
            var s = 0;
            var e = B - 1;
            long sum = 0;

            // first window sum calculation
            for (var i = s; i <= e; i++)
            {
                sum += A[i];
            }
            //handle edge cases for the first window when length of the  array is 1 for example
            if (sum == C)
            {
                return true;
            }
            // move to the  next index and calculate the sum in window
            s++;
            e++;

            // window loop 
            while (e < n)
            {
                sum = sum - A[s - 1] + A[e];
                if (sum == C)
                {
                    return true;
                }

                s++;
                e++;
            }

            return false;
        }

        public long MaxSubArraySumOfLengthK(int[] A, int B)
        {
            var n = A.Length;
            var s = 0;
            var e = B - 1;
            long sum = 0;
            long maxVal = long.MinValue;

            //if (B == 1)
            //{
            //    return A.Max();
            //}

            // first window sum calculation
            for (var i = s; i <= e; i++)
            {
                sum += A[i];
            }

            //handle edge cases for the first window when length of the  array is 1 for example
            if (sum == B)
            {
                return sum;
            }
            // move to the  next index and calculate the sum in window
            s++;
            e++;

            // window loop 
            while (e < n)
            {
                sum = sum - A[s - 1] + A[e];
                if (maxVal < sum)
                {
                    maxVal = sum;
                }

                s++;
                e++;
            }

            return maxVal;
        }

        //Given an array of length n return the least average of subarrrays of length k
        //public long LeastAvverageOfSubarraysOflengthK

        //function(A, B, C)
        //{
        //    let n = A.length;
        //    let s = 0;
        //    let e = B - 1;
        //    let sum = BigInt(0)

        //    for (let i = s; i < e; i++)
        //    {
        //        sum = sum + BigInt(A[i])
        //    }
        //    s++
        //    e++
        //    while (e < n)
        //    {
        //        sum = sum - BigInt(A[s - 1] + A[e])
        //        if (sum === C)
        //        {
        //            return 1
        //        }
        //        s++
        //        e++
        //    }
        //    return 0
        //}

        //Given an array A of length N, Find the maximum subarray sum out of all possible subarray of length B.
        //function(A, B)
        //{
        //    let n = A.length;
        //    let s = 0;
        //    let e = B - 1;
        //    let sum = BigInt(0);
        //    let maxVal = BigInt(0);
        //    for (let i = s; i <= e; i++)
        //    {
        //        sum = sum + BigInt(A[i])
        //    }
        //    s++
        //    e++

        //    while (e < n)
        //    {
        //        sum = sum - BigInt(A[s - 1]) + BigInt(A[e])
        //        if (maxVal < sum)
        //        {
        //            maxVal = sum

    }
}
