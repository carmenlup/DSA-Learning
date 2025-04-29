using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Assignment.Module2
{
    public class Session2BinarySearchAssignment
    {
        /// <summary>
        /// Medium
        /// 34 Find First and Last Position of Element in Sorted Array
        /// Time O(log n) / Space (1)
        /// https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] SearchRange(int[] nums, int target)
        {
            var n = nums.Length - 1;
            var left = 0;
            var right = n;
            var result = new[] { -1, -1 };

            if (nums.Length == 0)
                return result;

            //find start position
            while (left <= right)
            {
                var middle = left + (right - left) / 2;

                if (target == nums[middle] && (middle == 0 || nums[middle - 1] < nums[middle]))
                {
                    result[0] = middle;
                    break;
                }

                if (target > nums[middle])
                    left = middle + 1;
                else
                    right = middle - 1;
            }

            if (result[0] == -1)
                return result;

            left = 0;
            right = nums.Length - 1;

            //find end position
            while (left <= right)
            {
                var middle = left + (right - left) / 2;

                if (target == nums[middle] && (middle == n || nums[middle] < nums[middle + 1]))
                {
                    result[1] = middle;
                    break;
                }

                if (target >= nums[middle])
                    left = middle + 1;
                else
                    right = middle - 1;
            }

            return result;
        }

        /// <summary>
        /// Medium
        /// 162 Find Peak Element
        /// https://leetcode.com/problems/find-peak-element/
        /// Nice solution explained: https://leetcode.com/problems/find-peak-element/discuss/1290642/intuition-behind-conditions-complete-explanation-diagram-binary-search
        /// T.C -> O(log(n))
        /// S.C -> O(1)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int FindPeakElement(int[] input)
        {
            //validation
            if (input.Length == 1)
                return input[0];

            var start = 1;
            var end = input.Length - 1;

            // check if 0th/n-1th index is the peak element
            if (input[0] > input[1]) return input[0];
            if (input[input.Length - 1] > input[input.Length - 2]) return input[input.Length - 1];
            var result = -1;
            while (start <= end)
            {
                var mid = start + (end - start) / 2;

                if (input[mid] > input[mid - 1] && input[mid] > input[mid + 1])
                    return input[mid];

                if (input[mid] < input[mid - 1])
                {
                    result = input[mid];
                    end = mid - 1;
                }
                else if (input[mid] < input[mid + 1])
                    start = mid + 1;
            }

            return result;
        }
    }
}
