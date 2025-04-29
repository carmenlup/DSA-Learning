namespace Algorithms.Sessions.Module2
{
    public class Session1BinarySearch
    {
        /// <summary>
        /// Easy
        /// 704. Binary Search
        /// Source: https://leetcode.com/problems/binary-search/
        /// T.C: O(log n)
        /// S.C O(1)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int BinarySearch(int[] arr, int target)
        {
            var n = arr.Length - 1;
            int left = 0;
            int right = n;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                {
                    return mid;
                }

                if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1; // target not found
        }


        /// <summary>
        /// Given an ordered array find first occurence of a target value
        /// Source: https://takeuforward.org/data-structure/1st-occurrence-in-a-sorted-array/
        /// T.C = O(log n)
        /// S.C = O(1)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int FindOccurence(int[] arr, int target)
        {
            var n = arr.Length - 1;
            var left = 0;
            var right = n;
            var result = -1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (arr[mid] == target)
                {
                    result = mid;
                    right = mid - 1; // continue searching in the left half
                }
                else if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return result;
        }

        // find minima. given an array a value is minima if his value 
        // is strict less than his neighbours. Return the index of minima
        // 1. check if the first element is minima
        // 2. check if the last element is minima
        /// <summary>
        /// Find the index of the minima in an array
        /// Practice similar: https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int FindMinima(int[] arr)
        {
            if (arr.Length == 1)
                return 0;

            if (arr[0] < arr[1])
                return 0;

            if (arr[arr.Length - 1] < arr[arr.Length - 2])
                return arr.Length - 1;

            var left = 1;
            var right = arr.Length - 1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (arr[mid] < arr[mid - 1] && arr[mid] < arr[mid + 1])
                    return mid;

                if (arr[mid] > arr[mid - 1])
                    left = mid + 1;
                else
                    right = mid - 1;

            }

            return -1;
        }


        /// <summary>
        /// 69. Sqrt(x)
        /// Easy
        /// https://leetcode.com/problems/sqrtx/description/
        /// Solution:
        ///     - using binary search
        ///     - loop from 0 to x and
        ///     - check if mid * mid == x to find the solution
        /// T.C: O(log n)
        /// S.C: O(1)
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int MySqrt(int x)
        {
            var left = 0;
            var right = x;

            while (left < right)
            {
                var mid = left + (right - left) / 2;
                if (mid * mid == x)
                    return mid;

                if (mid * mid < x)
                    left = mid + 1;

                if (mid * mid > x)
                    right = mid - 1;
            }

            return left - 1;
        }
    }
}
