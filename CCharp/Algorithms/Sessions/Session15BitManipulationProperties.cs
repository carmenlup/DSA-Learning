using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sessions
{
    /// <summary>
    /// Bit Manipulation 1 - session Friday 29th Nov
    /// this class contains the implementation and applicability of bit manipulation 
    /// covered in class session
    /// </summary>
    public class Session15BitManipulationProperties
    {
        // find ith bit - use AND operator
        // set ith bit - use OR operator
        // unset ith bit - use AND operator and ~ operator (Question 3)
        // toggle ith bit - use XOR operator (Question 2)
        // update ith bit - clear ith bit and set ith bit
        // check if ith bit is set - use AND operator (Question 4)
        // check if ith bit is clear - use AND operator (Question 4)
        // clear all bits from MSB to ith bit - use AND operator
        // clear all bits from ith bit to 0 - use AND operator
        // set all bits from MSB to ith bit - use OR operator

        public int FindIthBit(int num, int i)
        {
            return (num & (1 << i)) != 0 ? 1 : 0;
        }

        /// <summary>
        /// Question 1: Given a number set ith bit and return the number obtained
        /// </summary>
        /// <param name="num"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public int SetIthBit(int num, int i)
        {
            num = (num | (1 << i));
            return num;
            // we can write this in one line
            // return num | (1 << i);
        }

        /// <summary>
        /// Question 2: Given a number toggle ith bit and return the number obtained
        /// </summary>
        /// <param name="num"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public int ToggleIthBit(int num, int i)
        {
            num = num ^ (1 << i);
            return num;
            // we can write this in one line
            // return num ^ (1 << i);
        }

        /// <summary>
        /// Question 3: Unset ith bit - use AND operator and ~ operator
        /// </summary>
        /// <param name="num"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public int ClearIthBit(int num, int i)
        {
            return num & ~(1 << i);
        }

        /// <summary>
        /// Question 4: Check if ith bit is set or not and return it
        /// </summary>
        /// <param name="num"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public int CheckIthBit(int num, int i)
        {
            // this can also be done usinf left sift operator but this can go on overflow
            // if(num & (1 << i) != 0)
            //     return 1;
            // return 0;
            return num & (1 >> i);
        }

        /// <summary>
        /// Question 4: Using left whift + and operator
        /// this can giveoverflow exception?
        /// </summary>
        /// <param name="num"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public bool IsIthBitUnset(int num, int i)
        {
            // return (num & (1 << i)) != 0;
            return (num & (1 >> i)) == 1;
        }

        /// <summary>
        /// Using right shift + and operator
        /// </summary>
        /// <param name="num"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public int IsIthBitSetRightShift(int num, int i)
        {
            return (num >> i) & 1;
        }


        /// <summary>
        /// Question 5: Count all set bits
        /// Solution 1
        /// T.C = O(log n)
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int CountAllSetBits(int num)
        {
            var count = 0;
            while (num > 0)
            {
                count += num & 1;
                num >>= 1;
            }

            return count;
        }

        /// <summary>
        /// Question 5: Count all set bits 
        /// Solution 1: traverse each bit and check if it is set
        /// T.C = O(32) ~ O(1)
        /// S.C = O(1)
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int CountOneBitsFor32Bit(int num)
        {
            var count = 0;
            for (var i = 0; i < 32; i++)
            {
                if ((num & 1) == 1)
                {
                    count++;
                }
                num = num >> 1;
            }

            return count;
        }

        /// <summary>
        /// Solution 2: Using Brian Kernighan’s Algorithm
        /// 
        /// Remarks: THis is better algo as in Solution 1 we ignore 32 as constant 
        /// whereas in this solution 32 is max max value of log(n)
        /// 
        /// T.C = O(log n)
        /// S.C = O(1)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int CountDigitOne(int n)
        {
            var res = 0;

            while(n > 0)
            {
                if((n & 1) == 1)
                {
                    res++;
                }
                n = n >> 1;
            }

            return res;
        }

        public int GenerateIntWithTheGivenNumberOfBitsAZerosBOnesCZeros(int a, int b, int c)
        {
            var num = 0;
            //for (var i = 0; i < a; i++)
            //{
            //    num = num << 1;
            //}

            var bitNo = c;

            for (var i = 0; i < b; i++)
            {
                num = (num << 1) | 1;
                bitNo++;
            }

            //for (var i = 0; i < c; i++)
            //{
            //    num = num << 1;
            //}

            return num;
        }

        #region Single number problems - Classic approach
        /// <summary>
        /// /// Easy
        /// 136. Single Number
        /// Source: https://leetcode.com/problems/single-number/
        /// 
        /// This problem can be solved using bit manipulation
        /// However we will solve this problem in a classic way first
        /// and we will generalize it for clasic approach 
        /// then we will solve and thing about bit manipulation
        /// Solution 1: Brute force
        ///     - Sort the array to cave the same numbers together
        ///     - Loop through the array and check if the current number is equal to the next number
        ///     - If it is equal then continue the loop and check next pair of numbers
        /// T.C = O(n log n)
        /// S.C = O(1)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int FindSingleNumberClasicApproach(int[] A)
        {
            Array.Sort(A);
            //for (var i = 0; i < A.Length; i = i + 2)
            //{
            //    for (var j = i + 1; j < A.Length - 1; j++)
            //    {
            //        if (A[i] == A[j])
            //        {
            //            break;
            //        }
            //        return A[i];
            //    }
            //}

            // We don't need to have 2 loops. one loop is enough and check next element
            // this will reduce the time complexity
            for (var i = 0; i < A.Length - 1; i = i + 2)
            {
                if (A[i] == A[i + 1])
                {
                    continue;
                }
                return A[i];
            }

            return A[A.Length - 1];
        }

        /// <summary>
        /// Medium
        /// 137. Single Number II
        /// https://leetcode.com/problems/single-number-ii/description/
        /// 
        /// This is similar with the above problem  only that 3 numbers are repeated
        /// Solution 1: Brute force
        ///     - Sort the array to cave the same numbers together
        ///     - Loop through the array and check if the current number is equal to the third number
        ///     - If it is equal then continue the loop and check next 3 elements
        /// T.C = O(n log n)
        /// S.C = O(1)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int SingleNumber2(int[] A)
        {
            Array.Sort(A);
            for (var i = 0; i < A.Length - 2; i = i + 3)
            {
                if (A[i] == A[i + 2])
                {
                    continue;
                }
                return A[i];
            }
            return A[A.Length - 1];
        }

        /// <summary>
        /// We can generalize the problem above.
        /// The above problems are a special case of the next problem:
        /// Given an array of integers, every element appears k (k > 1) times except for one, 
        /// which appears only once. Return the single number
        /// 
        /// T.C = O(n log n)
        /// S.C = O(1)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int SingleNumberGeneralisation(int[] A, int k)
        {
            Array.Sort(A);
            for (var i = 0; i < A.Length - k + 1; i = i + k)
            {
                if (A[i] == A[i + k - 1])
                {
                    continue;
                }
                return A[i];
            }
            return A[A.Length - 1];
        }
        #endregion

        #region Single number problems - bit manipulation
        /// <summary>
        /// Easy
        /// 136. Single Number
        /// Source: https://leetcode.com/problems/single-number/
        /// Solution 1: Brut force approach
        ///     Sort the array and traverse the array and check if the current element is equal to the next element
        ///     T.C -> O(n log(n))
        ///     S.C -> O(1)
        /// Solution 2: Using hashset
        ///     Traverse the array and add the element to the hashset if it is not present
        ///     Hasset will have key = number and value = count
        ///     Traverse the Haset and return the element with count = 1
        ///     T.C -> O(n)
        ///     S.C -> O(n)
        /// Solution 3: Optimal Solution Using XOR operator
        ///     The next properties are used:
        ///     a ^ a = 0
        ///     comutativity a ^ b = b ^ a
        ///     asociativity a ^ b ^ c = a ^ (b ^ c) = (a ^ b) ^ c
        ///     a ^ 0 = a
        ///     We traverse the array once and based on properties of XOR double elements will
        ///     cancel each other and we will have the single element
        ///     T.C -> O(n)
        ///     S.C -> O(1)
        ///     
        /// Sum = 5 + 2 + (-1) + (-2) + 1
        /// </summary>
        public int FindSingle2(int[] input)
        {
            var res = 0;

            for (var i = 0; i < input.Length; i++)
            {
                res ^= input[i];
            }

            return res;
        }

        /// <summary>
        /// Medium
        /// 137. Single Number II
        /// https://leetcode.com/problems/single-number-ii/description/
        /// Solution:
        ///     Count the numbers in which they are set and check if is in 3n + 1 format to count
        /// T.C = O(n)
        /// S.C = O(1)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int FindSingle3(int[] input)
        {
            /*
             * cchecck this code
                int ones = 0, twos = 0;
                foreach(var num in nums)
                {
                    ones = (num ^ ones) & ~twos;
                    twos = (num ^ twos) & ~ones;
                }
                return ones;
             * */
            var res = 0;

            for(var i = 0; i < 32; i++)
            {
                var count = 0;
                for (var j = 0; j < input.Length; j++)
                {
                    if (((input[j] >> i) & 1) == 1)
                        count++;
                }

                if(count % 3 == 1)
                {
                    res = (1 << i) | res;
                }
            }

            return res;
        }

        /// <summary>
        /// Medium
        /// 260. Single Number III
        /// Source: https://leetcode.com/problems/single-number-iii/
        /// Solution:
        ///     - calculate the XOR of all the elements
        ///     - find the rightmost set bit
        ///     - calculate the XOR into 32 different groups
        ///         - if the bit is set then add to group 1
        ///         - if the bit is not set then add to group 2
        /// T.C = O(n)
        /// S.C = O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>

        public int[] FindSingleTwoNo(int[] nums)
        {
            var allXor = 0;
            for(var i = 0; i < nums.Length; i++)
            {
                allXor ^= nums[i];
            }

            for(var i = 0; i < 32; i++)
            {
                if (((allXor >> i) & 1) == 1)
                {
                    allXor = i;
                    break;
                }
            }

            var res = new int[2];
            for (var i = 0; i < nums.Length; i++)
            {
                if (((nums[i] >> allXor) & 1) == 0)
                {
                    res[0] ^= nums[i];
                }
                else
                {
                    res[1] ^= nums[i];
                }
            }

            return res;

        }
        #endregion
    }
}
