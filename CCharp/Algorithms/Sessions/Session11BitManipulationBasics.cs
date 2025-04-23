using System.Text;

namespace Algorithms.Sessions
{
    public class Session11BitManipulationBasics
    {
        /// <summary>
        /// Convert a number from base 10 to base x
        /// Solution:
        ///     There are certain steps to convert a number from base 10 to base x
        ///     Math operations using reminder and division, 
        ///     also in case we are working with even numbers we need to count the number of zeros
        /// Remark: if we manipulating string we need to reverse the string in some languages like C# 
        ///         or constrict directly the reversed sting in languages like python
        /// Steps:
        /// 1. for even number we will have the issue that the end is zero and in revers that zero will be lost
        ///    -> for tthat reason we are counting the number of zeros and we will add them at the end
        ///    Remark: important to find zeros at the beginning and n will b erecalculated
        /// 2. reminder = n % x
        /// 3. reverse = reverse * 10 + reminder
        /// 4. new number -> n = n / x
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public int ConvertPositiveInBaseX(int n, int x)
        {
            int rev = 0;
            var count = 0;

            while (n > 0 && n % x == 0)
            {
                count++;
                n = n / x;
            }

            while (n > 0)
            {
                var rem = n % x;
                rev = rev * 10 + rem;
                n = n / x;
            }

            // the code below can be replaced with rev = rev * Math.Pow(10, count);
            while (count > 0)
            {
                rev = rev * 10;
                count--;
            }

            return rev;
        }

        /// <summary>
        /// Convert a NEGATIVE number from base 10 to base x
        /// Steps:
        ///     - We will use the same steps as the previous solution for all positives
        ///       with the next steps for negative numbers
        ///     - Convert the absolute value of the number to base x
        ///     - Invert the bits of the number
        ///     - Add 1 to the number
        /// 
        /// Check the solution on leet code on the next problem:
        /// Leet Code Problem To practice: This Is a generalization of the next problem:
        /// Easy
        /// 504. Base 7
        /// https://leetcode.com/problems/base-7/description/
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public int ConvertInBaseX(int n, int x)
        {
            if (n == 0)
                return 0;
            var count = 0;
            var rev = 0;
            var isNegative = n < 0;
            n = Math.Abs(n);

            while (n > 0 && n % x == 0)
            {
                count++;
                n = n / x;
            }

            while (n > 0)
            {
                var rem = n % x;
                rev = rev * 10 + rem;
                n = n / x;
            }

            while (count > 0)
            {
                rev = rev * 10;
                count--;
            }

            if (isNegative)
            {
                rev = ~rev + 1;
            }

            return rev;
        }

        /// <summary>
        /// Easy
        /// 66. Add Binary
        /// Source: https://leetcode.com/problems/add-binary/
        /// Solution:
        ///     - We will use two pointers to iterate over the two strings
        ///     - We will use a carry to store the value of the sum of the two numbers
        ///     - We will use a StringBuilder to store the result
        ///     - We will iterate over the two strings and calculate the sum and the carry
        ///       Remark: in case of string we need to convert the character to integer or
        ///               we can use the ASCII value of the character
        ///     - We will add the carry to the result
        ///     - We will reverse the result
        ///       Remark: reversing the sting at the end depends on the Programming language.
        ///               Some languages like Python can directly construct the reversed string
        ///               by adding the result in front of the string
        ///     - We will return the result
        /// T.C : O(n)
        /// S.C : O(n) -> for the result string builder is used
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public string AddBinary(string a, string b)
        {
            var result = new StringBuilder();
            var carry = 0;
            var i = a.Length - 1;
            var j = b.Length - 1;

            while (i >= 0 || j >= 0)
            {
                var sum = carry;
                if (i >= 0)
                {
                    sum += a[i] - '0';
                    i--;
                }

                if (j >= 0)
                {
                    sum += b[j] - '0';
                    j--;
                }

                result.Append(sum % 2);
                carry = sum / 2;
            }

            if (carry > 0)
                result.Append(carry);


            // reverse the result
            var arr = result.ToString().ToCharArray();
            Array.Reverse(arr);
            return new string(arr);

            /*
                https://leetcode.com/problems/sum-of-digits-in-base-k/description
                https://leetcode.com/problems/base-7/description/
            https://leetcode.com/problems/convert-to-base-2/description/https://leetcode.com/problems/convert-to-base-2/description/

                Given an integer n (in base 10) and a base k, return the sum of the digits of n after converting n from base 10 to base k.
            */
        }
    }
}
