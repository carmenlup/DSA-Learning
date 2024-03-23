using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sessions
{
    public class Session4CarryForward
    {
        /// <summary>
        /// Count number of pair in a array of char such as for a and d
        /// where a is the first chat and d the second
        /// T.C = O(n^2)
        /// S.C = O(1)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int CountPairsOfCharOneAndChar2BruteForce(string s)
        {
            var count = 0;
            for (var i = 0; i < s.Length; i++)
            {

                if (s[i] == 'a')
                {
                    for (var j = i + 1; j < s.Length; j++)
                    {
                        if (s[j] == 'g')
                            count++;
                    }
                }
            }

            return count;
        }

        /// <summary>
        /// Count number of pair in a array of char such as for a and d
        /// where a is the first chat and d the second
        /// Solution: Carry forward from left to right
        ///     Start from end to start count d and carry forward pairs
        /// T.C = O(n)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int CountPairsOfCharOneAndChar2Back(string s)
        {
            var countG = 0;
            var pairs = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == 'g')
                {
                    countG++;
                }
                else
                {
                    if (s[i] == 'a')
                        pairs += countG;
                }
            }
            return pairs;
        }

        /// <summary>
        /// Count number of pair in a array of char such as for a and d
        /// where a is the first chat and d the second
        /// T.C = O(n)
        /// Solution: Carry forward from left to right
        ///     Loop through the array, count a and carry forward pairs
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int CountPairsOfCharOneAndChar2(string s)
        {
            var countA = 0;
            var pairs = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a')
                    countA++;
                else
                {
                    if (s[i] == 'g')
                        pairs += countA;
                }
            }

            return pairs;
        }

        /// <summary>
        /// Count all leaders in an array of integers
        /// An item is a leader if all numbers from left are less than the current number
        /// arr[0] is always 0
        /// Solution:
        ///     - Iterate over the array and get max
        ///     - check if max is less than array[i]
        /// T.C = O(n^2)
        /// S.C = O(1)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int LeadersBruteForce(int[] input)
        {
            var count = 1;

            for (int i = 1; i < input.Length; i++)
            {
                var max = int.MinValue;
                for (int j = 0; j <= i; j++)
                {
                    if (max <= input[j])
                        max = input[j];
                }

                if (max <= input[i])
                    count++;
            }

            return count;
        }

        /// <summary>
        /// Count all leaders in an array of integers
        /// An item is a leader if all numbers from left are less than the current number
        /// arr[0] is always 0
        /// Solution:
        ///     - trace max: once a number is  a leader for all left values
        ///                  the next leader can be only a value that is
        ///                  greater than the current leader 
        /// T.C = O(n)
        /// S.C = O(1)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int Leaders(int[] input)
        {
            var count = 1;
            var max = input[0];
            for (var i = 1; i < input.Length; i++)
            {
                // check if input[i] is leader
                if (input[i] > max)
                {
                    max = input[i];
                    count++;
                }
            }

            return count;
        }


    }
}
