using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Contests
{
    public class Module1Contest25Nov
    {

        // maximum cost of the path
        // Source: https://leetcode.com/problems/maximum-score-from-performing-multiplication-operations/


        /// <summary>
        /// Find the count of numbers divisible by 7 and with at least two numbers greater than it
        /// Source:
        /// Solution: 
        ///     - Sort the array in descending order this will help to skip first 2 numbers divisible by 7
        ///     - Count the numbers divisible by 7 and with at least two numbers greater than it
        /// T.C = O(nlogn)
        /// S.C = O(1)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int Find7Division(int[] input)
        {
            Array.Sort(input);
            Array.Reverse(input);

            // 14, 11, 9, 8, 7
            var count = 0;
            //var firstPrimeIndex = -1;
            var count7Div = 0;
            for (var i = 0; i < input.Length; i++)
            {
                // we can use this condition instead of input[i] != 0 and if cout > 2 can go outside of if
                //if (input[i] < 7)
                //    break;
                if (input[i] % 7 == 0 && input[i] != 0)
                {
                    count++;

                    if (count > 2 /*&& i > 1*/)
                    {
                        count7Div++;
                    }
                }

                
            }

            return count7Div;
        }

        /// <summary>
        /// first and last index prime numbers
        /// Source leet code: https://leetcode.com/problems/maximum-prime-difference/description/
        /// Solution 1: Brute force
        ///     Loop through the array and find the first and last prime numbers
        /// T.C = O(n * sqrt(n))
        /// S.C = O(1)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int MaximumPrimeDifference(int[] input)
        {
            var firstPrimeIndex = -1;
            var lastPrimeIndex = -1;

            for (var i = 0; i < input.Length; i++)
            {
                if (IsPrime(input[i]))
                {
                    if (firstPrimeIndex == -1)
                        firstPrimeIndex = i;

                    lastPrimeIndex = i;
                }
            }

            return lastPrimeIndex - firstPrimeIndex;
        }

        private bool IsPrime(int n)
        {
            if (n <= 1)
                return false;

            for (var i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Mediun
        /// Source leet code: https://leetcode.com/problems/maximum-prime-difference/description/
        /// Solution 2: Otimissed solution
        ///     - Because the numbers are small (100) we can create a hasset of prime numbers
        ///     - traverse the array from start and end and find the first by checking if the number is in the hashset
        ///     - traverse the array from end to start and find the last prime number by checking if the number is in the hashset
        ///     - return the difference
        /// T.C = O(n)
        /// S.C = O(1) // because the prime numbers are fixed to max 100
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MaximumPrimeDifferenceOptimal(int[] nums)
        {
            int[] primes = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            int n = nums.Length, min = 0, max = nums.Length - 1;
            var set = new HashSet<int>(primes);
            for (int i = 0; i < n; i++)
            {
                if (set.Contains(nums[i]))
                {
                    min = i;
                    break;
                }
            }
            for (int i = n - 1; i >= 0; i--)
            {
                if (set.Contains(nums[i]))
                {
                    max = i;
                    break;
                }
            }
            return max - min;
        }
    }
}
