namespace Algorithms.Sessions.Module2
{
    public class Session3PracticeBinarySearch
    {
        /// <summary>
        /// Medium
        /// 33 Search in Rotated Sorted Array
        /// Source: https://leetcode.com/problems/search-in-rotated-sorted-array/
        /// T.C = O(log n);
        /// S.C = O(1)
        /// </summary>
        /// <param name="input"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int Search(int[] input, int target)
        {
            var slow = 0;
            var fast = input.Length - 1;
            while (slow <= fast)
            {
                var mid = slow + (fast - slow) / 2;

                if (input[mid] == target)
                    return mid;

                if (input[slow] <= input[mid]) // check left part
                {
                    if (input[slow] <= target && target < input[mid]) // check if target is in interval
                    {
                        fast = mid - 1;
                    }
                    else
                    {
                        slow = mid + 1;
                    }
                }
                else // check the riche part
                {
                    if (input[mid] <= target && target <= input[fast]) // check if target is in interval
                    {
                        slow = mid + 1;
                    }
                    else
                    {
                        fast = mid - 1;
                    }
                }

            }

            return -1; // target not found
        }

        /// <summary>
        /// Medium
        /// 540. Single Element in a Sorted Array
        ///  //https://leetcode.com/problems/single-element-in-a-sorted-array/
        /// T.C = O(log n);
        /// S.C = O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNonDuplicate(int[] nums)
        {
            int low = 0;
            int high = nums.Length - 1;

            var result = 0;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;


                if ((mid == 0 || nums[mid] != nums[mid - 1]) &&
                    (mid == nums.Length - 1 || nums[mid] != nums[mid + 1]))
                    return nums[mid];

                if (nums[mid] == nums[mid - 1]) // mid is the second occurence
                {
                    if (mid % 2 == 0) //second occurence even => search to left
                    {
                        //result = nums[mid];
                        high = mid - 1;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                }
                else if (nums[mid] == nums[mid + 1]) // mid is first occurence
                {
                    if (mid % 2 == 0)
                    {
                        //result = nums[mid];
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }
            }

            return -1; //single element not found
        }

        /// <summary>
        /// Hard
        /// 4. Median of Two Sorted Arrays
        /// https://leetcode.com/problems/median-of-two-sorted-arrays/
        /// Median is the middle value in an ordered integer list.
        /// If the size of the list is even, there is no middle value and the median is the average of the two middle values.
        /// Solution 1:
        /// - merge the two sorted arrays and then find median
        /// -> T.C: O(n + m) where n and m are the lengths of the two arrays
        /// -> S.C: O(n + m) for the merged array
        /// 
        /// Solution 2:
        /// - use binary search to find the median
        /// -> T.C: O(log(min(n, m))) where n and m are the lengths of the two arrays
        /// -> S.C: O(1)
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length)
            {
                return FindMedianSortedArrays(nums2, nums1);
            }

            int x = nums1.Length;
            int y = nums2.Length;

            int low = 0;
            int high = x;

            while (low <= high)
            {
                int partitionX = (low + high) / 2;
                int partitionY = (x + y + 1) / 2 - partitionX;

                // If partitionX is 0 it means nothing is there on left side. Use -inf for maxLeftX
                // If partitionX is length of input then there is nothing on right side. Use +inf for minRightX
                int maxLeftX = (partitionX == 0) ? int.MinValue : nums1[partitionX - 1];
                int minRightX = (partitionX == x) ? int.MaxValue : nums1[partitionX];

                int maxLeftY = (partitionY == 0) ? int.MinValue : nums2[partitionY - 1];
                int minRightY = (partitionY == y) ? int.MaxValue : nums2[partitionY];

                if (maxLeftX <= minRightY && maxLeftY <= minRightX)
                {
                    // We have partitioned array at correct place
                    if ((x + y) % 2 == 0)
                    {
                        return (Math.Max(maxLeftX, maxLeftY) + Math.Min(minRightX, minRightY)) / 2.0;
                    }

                    return Math.Max(maxLeftX, maxLeftY);
                }

                if (maxLeftX > minRightY)
                {
                    // we are too far on right side for partitionX. Go on left side.
                    high = partitionX - 1;
                }
                else
                {
                    // we are too far on left side for partitionX. Go on right side.
                    low = partitionX + 1;
                }
            }

            return -1; // If we reach here, it means the input arrays were not sorted.

        }
    }
}
