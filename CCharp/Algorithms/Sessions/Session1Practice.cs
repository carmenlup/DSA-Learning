using System.Text;

namespace Algorithms.Sessions
{
    public class Session1Practice
    {
        /// <summary>
        /// https://www.geeksforgeeks.org/problems/number-of-factors1435/1
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public int CountFactors(int N)
        {
            var count = 0;
            for (var i = 1; i * i <= N; i++)
            {
                if (N % i == 0)
                {
                    if (i * i == N)
                        count++;
                    else
                        count += 2;
                }
            }
            return count;
        }

        /// <summary>
        /// https://www.geeksforgeeks.org/problems/prime-number2314/1
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public int IsPrime(int N)
        {
            if (N == 1)
                return 0;

            for (var i = 2; i * i <= N; i++)
            {
                if (N % i == 0)
                    return 0;
            }

            return 1;
        }

        /// <summary>
        /// 189. Rotate Array
        /// Medium
        /// O(n) T; O(1) S
        /// https://leetcode.com/problems/rotate-array/description/
        /// </summary>
        /// <param name="input"></param>
        /// <param name="k"></param>
        public void Rotate(int[] nums, int k)
        {
            if (nums.Length == 1)
                return;

            k = k % nums.Length;

            Reverse(nums, 0, nums.Length - 1);
            Reverse(nums, 0, k - 1);
            Reverse(nums, k, nums.Length - 1);

        }

        private void Reverse(int[] input, int startIndex, int endIndex)
        {
            while (startIndex < endIndex)
            {
                var temp = input[startIndex];
                input[startIndex] = input[endIndex];
                input[endIndex] = temp;
                startIndex++;
                endIndex--;
            }
        }
    }
}
