using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.PracticeSimilar
{
    public class Session1
    {
        /// <summary>
        /// https://www.geeksforgeeks.org/problems/all-divisors-of-a-number/1
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public string DivisorsInOrder(int n)
        {
            var sb = new StringBuilder();
            var sbPair = new StringBuilder();
            for (var i = 1; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    sb.Append(i);
                    sb.Append(' ');
                    if (i * i < n)
                    {
                        sbPair.Insert(0, ' ');
                        sbPair.Insert(0, n / i);
                    }
                }
            }

            return sb + sbPair.ToString().Trim();
        }

        public int CountPrimes(int n)
        {
            return 0;
        }


        // https://leetcode.com/problems/prime-palindrome/description/

        // https://leetcode.com/problems/sum-of-even-numbers-after-queries/

        https://leetcode.com/problems/count-substrings-starting-and-ending-with-given-character/description/

        #region session 3
        /// <summary>
        /// https://www.geeksforgeeks.org/problems/leaders-in-an-array-1587115620/1?ref=header_search
        /// T.C = O(n)
        /// S.C = O(n)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public List<int> Leaders(int[] a, int n)
        {
            var result = new List<int>();
            result.Add(a[n - 1]);
            var max = a[n - 1];

            for (int i = n - 2; i >= 0; i--)
            {
                //if (max > input[i])
                // continue;
                if (max <= a[i])
                {
                    max = a[i];
                    result.Add(a[i]);
                }
            }


            var left = 0;
            var right = result.Count - 1;
            while (left < right)
            {
                var temp = result[left];
                result[left] = result[right];
                result[right] = temp;
                left++;
                right--;
            }

            return result;
        }
        #endregion
    }
}
