namespace Algorithms.Sessions
{
    public class Session8SubArraysAndPrefixSum
    {
        /// <summary>
        /// Brute force approach
        /// Source leetcode: https://leetcode.com/problems/range-addition/
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
        /// Given an array and a list of queries with index and value
        /// return sums after applying the queries
        /// T.C = O(q*n)
        /// S.C = O(n)
        /// </summary>
        /// <param name="input"></param>
        /// <param name="queries"></param>
        /// <returns></returns>
        public long[] QueryArrayBruteForce(int[] input, int[][] queries)
        {
            var n = input.Length;
            var prefixSum = new long[n];
            prefixSum[0] = input[0];
            var result = new long[n];
            for (var i = 0; i < queries.Length; i++)
            {
                for (var j = i; j < n;)
                {
                    result[j] = result[j] + queries[i][2];
                }
            }

            return result;
        }

        public long[] QueryArray(int[] input, int[][] queries)
        {
            var n = input.Length;
            var result = new long[n];
            
            for (var i = 0; i < queries.Length; i++)
            {
                var index = queries[i][0];
                int val = queries[i][1];
                result[index] += val;
            }

            // apply prefixSum
            for (var i = 1; i < n; i++)
            {
                result[i] += result[i - 1] + result[i];
            }

            return result;
        }

        /// <summary>
        /// Given an array and a list of queries with start index, end index and value
        /// return the sum of the array after applying the queries
        /// T.C = O(q*n)
        /// </summary>
        /// <param name="input"></param>
        /// <param name="query"></param>
        /// <returns></returns>
        public long[] QueryArrayInACertainRangeBruteForce( int[] input, int[][] query)
        {
            var n = input.Length;
            var  result = new long[n];
            for (var i = 0; i < query.Length; i++)
            {
                
                var l = query[i][0];
                var r = query[i][1];
                var val = query[i][2];

                for (var j = l; j <= r; j++)
                {
                    result[j] += val;
                }
            }
            return result;
        }

        /// <summary>
        /// Solution:
        /// 1. add the value till the end of array
        /// 2. substract the value from the end of the array till e
        /// add  v [s, n-1], -v [e+1, n-1]
        /// 3. calculate the prefix summ
        /// Remark: if e is last index of the array we do not need to substract
        /// T.C  = O(q + n)
        /// S.C = O(n)
        /// </summary>
        /// <param name="input"></param>
        /// <param name="query"></param>
        /// <returns></returns>
        public long[] QueryArrayInACertainRange(int[] input, int[][] query)
        {
            var n = input.Length;
            var result = new long[n];
            for (var i = 0; i < query.Length; i++)
            {

                var l = query[i][0];
                var r = query[i][1];
                var val = query[i][2];
                result[l] += val;
                if(r < n - 1)
                    result[r + 1] = result[r] - val;

            }

            for (int i = 0; i < result.Length; i++)
            {
                result[i] += result[i - 1];
            }
          
            return result;
        }

       


    }
}
