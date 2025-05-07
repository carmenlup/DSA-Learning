namespace Algorithms.Sessions.Module1
{
    public class Session21HashingBasics
    {
        // Given an array of n elements and a query of m elements,
        // find the frequency of each element in the array.
        // Source : https://www.geeksforgeeks.org/counting-frequencies-of-array-elements/
        // Time Complexity: O(n)
        // Space Complexity: O(n)
        public int[] FrequencyCount(int[] arr, int[] query)
        {
            // Create a frequency map to count the occurrences of each element
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

            // Count the frequency of each element in the array
            for (int i = 0; i < arr.Length; i++)
            {
                if (frequencyMap.ContainsKey(arr[i]))
                {
                    frequencyMap[arr[i]]++;
                }
                else
                {
                    frequencyMap[arr[i]] = 1;
                }
            }
            // add a result array to store the frequency
            var result = new int[query.Length];

            //check if the query value is in frequency map


            for (var i = 0; i < query.Length; i++)
            {
                if (frequencyMap.ContainsKey(query[i]))
                {
                    result[i] = frequencyMap[query[i]];
                }
                else
                {
                    result[i] = 0;
                }
            }
            return result;
        }

        /// <summary>
        /// Given an array of n elements, find the number of distinct elements in the array.
        /// Solution:
        ///  - Use a HashSet to store the distinct elements
        ///  - Iterate through the array and add each element to the HashSet
        ///  - The size of the HashSet will be the number of distinct elements
        /// Source: https://www.geeksforgeeks.org/count-distinct-elements-in-an-array/
        /// T.C = O(n)
        /// S.C = O(n)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int DistinctElements(int[] arr)
        {
            HashSet<int> distinctElements = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                distinctElements.Add(arr[i]);
            }
            return distinctElements.Count();
        }

        /// <summary>
        /// Medium
        /// 3. Longest Substring Without Repeating Characters
        /// Source: https://leetcode.com/problems/longest-substring-without-repeating-characters/
        /// T.C = O(n^2)
        /// S.C = O(n)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int LengthOfLongestSubstring(string s)
        {
            var longest = 0;
            for (var i = 0; i < s.Length; i++)
            {
                var set = new HashSet<char>();
                var count = 0;
                for (var j = i; j < s.Length; j++)
                {
                    if (set.Contains(s[j]))
                    {
                        break;
                    }
                    set.Add(s[j]);
                    count++;
                }
                longest = Math.Max(longest, count);
            }
            return longest;
        }

        #region additional problems

        /// <summary>
        /// 1748. Sum of Unique Elements
        /// Source:: https://leetcode.com/problems/sum-of-unique-elements/
        /// T.C = O(n)
        /// S.C = O(n)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SumOfUnique(int[] nums)
        {
            var distinctNumbers = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var key = nums[i];
                if (distinctNumbers.Keys.Contains(nums[i]))
                {
                    distinctNumbers[key] = 0;
                }
                else
                    distinctNumbers[key] = nums[i];
            }

            var sum = 0;
            foreach (var num in distinctNumbers)
            {
                sum += num.Value;
            }

            return sum;

        }

        #endregion

    }
}
