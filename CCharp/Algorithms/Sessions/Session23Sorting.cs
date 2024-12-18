using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Algorithms.Sessions
{
    public class Session23Sorting
    {
        // find the smalest number that can be formed by rearanging the digits of a given array
        // return the array in form of slalest number
        // problem in the class is related to sorting
        // however the problem may contain the contition of non zero elements leading

        /// <summary>
        /// Medium
        /// 2165. Smallest Value of the Rearranged Number
        /// Source: https://leetcode.com/problems/smallest-value-of-the-rearranged-number/description/
        /// Solution:
        ///     - create a frequency array - 10 length array yhet eill contain the frequency of each digit
        ///     - loop through the array and reconstructt the number based by digits
        ///     - considering the negative / positive nummbers
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public long SmalestNumber(long num)
        {
            if (num == 0)
                return num;

            // check if the number is negative to keep the sign
            var isNegative = num < 0;
            num = Math.Abs(num);

            // create a frequency array
            var frequency = new int[10];
            while (num > 0)
            {
                frequency[num % 10]++;
                num /= 10;
            }

            // reconstruct the number
            // initialize num with 0 as long
            num = 0;

            if (isNegative)
            {
                for (var i = 9; i >= 0; i--)
                {
                    while (frequency[i] > 0)
                    {
                        num = num * 10 + i;
                        frequency[i]--;
                    }
                }
                // the result should be negative
                return -num;
            }

            if (frequency[0] > 0)
            {
                var k = 1;
                while (frequency[k] == 0)
                {
                    k++;
                    continue;
                }
                num = k;
                frequency[k]--;
            }

            for (var i = 0; i < 10; i++)
            {
                while (frequency[i] > 0)
                {
                    num = num * 10 + i;
                    frequency[i]--;
                }
            }

            return num;
        }

        /// <summary>
        /// Solution:
        ///     - create a frequency array - 10 length array yhet eill contain the frequency of each digit
        ///     - loop throught the freqency array and replace the elements in the original array
        ///       with the index of the frequency array
        ///     - keep counter for index of the original array
        ///     
        /// Remark: this sollution will work only for positive numbers
        /// T.C = O(num)
        /// S.C = O(1)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int[] SmalestNumberPositiveDigits(int[] array)
        {
            var frequency = new int[10];
            for (var i = 0; i < array.Length; i++)
            {
                frequency[array[i]]++;
            }

            var k = 0;
            for (var i = 0; i < 10; i++)
            {
                for (var j = 0; j < frequency[i]; j++)
                {
                    array[k] = i;
                    k++;
                }
            }

            return array;
        }


        /// <summary>
        /// Merge all email imbox in cronological order
        /// Solution:
        ///     - this problem is similar to merging 2 sorted arrays problem
        ///     - depending on the imput given the implementation may vary 
        ///     - 
        /// Practice similar at Source: https://leetcode.com/problems/merge-sorted-array/
        /// T.C = O(num)
        /// S.C = O(1)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int[] MergeAllImboxEmails(int[] mailbox1, int[] mailbox2)
        {
            var m = mailbox1.Length;
            var n = mailbox2.Length;
            var merged = new int[m + n];

            var k = 0;
            var i = 0;
            var j = 0;

            while (i < m && j < n)
            {
                if (mailbox1[i] < mailbox2[j])
                {
                    merged[k] = mailbox1[i];
                    k++;
                    i++;
                }
                else
                {
                    merged[k] = mailbox2[j];
                    k++;
                    j++;
                }
            }

            while (i < m)
            {
                merged[k] = mailbox1[i];
                k++;
                i++;
            }

            while (j < n)
            {
                merged[k] = mailbox2[j];
                k++;
                j++;
            }

            return merged;
        }

        /// <summary>
        /// Given an array where odd and even elements are sorted, sort the entire array
        /// Source: https://leetcode.com/problems/sort-array-by-parity-ii/
        /// Solution: 
        ///     - we will crerate 2 lists for odd and even numbers
        ///     - we will use 2 pointers to iterate over the array
        ///     - we will add the elements to the original array in the order        ///     
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int[] SortArray(int[] array)
        {
            var odd = new List<int>();
            var even = new List<int>();

            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    even.Add(array[i]);
                else
                    odd.Add(array[i]);
            }

            var k = 0;
            var o = 0;
            var e = 0;
            while (o < odd.Count && e < even.Count)
            {
                if (odd[o] < even[e])
                {
                    array[k] = odd[o];
                    k++;
                    o++;
                }
                else
                {
                    array[k] = even[e];
                    k++;
                    e++;
                }
            }

            while (o < odd.Count)
            {
                array[k] = odd[o];
                k++;
                o++;
            }

            while (e < even.Count)
            {
                array[k] = even[e];
                k++;
                e++;
            }

            return array;
        }
    }
}
