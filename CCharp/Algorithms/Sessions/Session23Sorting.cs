namespace Algorithms.Sessions
{
    public class Session23Sorting
    {
        #region sorting 1
        /// <summary>
        /// 3469. Find Minimum Cost to Remove Array Elements
        /// https://leetcode.com/problems/find-minimum-cost-to-remove-array-elements/description/
        /// T.C = O(nlog(n))
        /// S.C = O(1)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int MinCost(int[] arr)

        {
            //sort the arr in descending order
            Array.Sort(arr);
            Array.Reverse(arr);

            var sum = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                sum += (i + 1) * arr[i];
            }

            return sum;
        }

        /// <summary>
        /// https://www.geeksforgeeks.org/noble-integers-in-an-array-count-of-greater-elements-is-equal-to-value/
        /// T.C = O(n^2)
        /// S.C = O(1)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int NobleNumberBruteForce(int[] arr)
        {
            var countNobleNumber = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                var count = 0;
                for (var j = 0; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                        count++;
                }

                if (count == arr[i])
                    countNobleNumber++;
            }

            return countNobleNumber;
        }

        /// <summary>
        /// Noble Number
        /// T.C = O(nlog(n))
        /// S.C = O(1)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int NobleNumber(int[] arr)
        {
            Array.Sort(arr);
            var countNobleNumber = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] == i)
                    countNobleNumber++;
            }
            return countNobleNumber;
        }

        /// <summary>
        /// https://www.interviewbit.com/problems/noble-integer/
        /// T.C = O(nlog(n))
        /// S.C = O(1)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int NobleNumber(List<int> arr)
        {
            var numbers = arr.OrderDescending().ToList();

            for (var p = 0; p < numbers.Count; p++)
            {
                if (numbers[p] == p)
                    return 1;
            }
            return -1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int NobelNumberDuplicateValues(int[] arr)
        {
            Array.Sort(arr);
            var countNobleNumber = 0;
            var count = 0;

            for (var i = 1; i < arr.Length; i++)
            {
                if (arr[i] != arr[i - 1])
                {
                    count = i;
                }

                //SKIP DUPLICATE VALUES
                 if (arr[i] == arr[i - 1])
                    continue;

                if (arr[i] == count)
                    countNobleNumber++;

                //reset value
                //count = 0;
            }
            return countNobleNumber;
        }
        #endregion


        //find the smallest number that can be formed by re-arranging the digits of a given number
        //return the number in form of smallest number
        //problem in the class is related to sorting
        //however the problem may contain the condition of non-zero elements leading

        /// <summary>
        /// Medium
        /// 2165. Smallest Value of the Rearranged Number
        /// Source: https://leetcode.com/problems/smallest-value-of-the-rearranged-number/description/
        /// Solution:
        ///     - create a frequency array - 10 length array that will contain the frequency of each digit
        ///     - loop through the array and reconstruct the number based by digits
        ///     - considering the negative / positive numbers edge cases
        /// a) if the number is 0 return 0
        /// b) if the number is negative keep the sign and add the digits in descending order
        /// c) if the number is positive reconstruct the number as follows:
        ///    - if the number contains 0, we will add the first non-zero digit to the number   
        ///    - we will add the rest of the digits in ascending order        
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public long SmallestNumber(long number)
        {
            if (number == 0)
                return number;

            //check if the number is negative to keep the sign
             var isNegative = number < 0;
            number = Math.Abs(number);

            //create a frequency number
             var frequency = new int[10];
            while (number > 0)
            {
                frequency[number % 10]++;
                number /= 10;
            }

            //reconstruct the number
            //initialize num with 0 as long
             number = 0;

            //-9 < -8
             if (isNegative)
            {
                for (var i = 9; i >= 0; i--)
                {
                    while (frequency[i] > 0)
                    {
                        number = number * 10 + i;
                        frequency[i]--;
                    }
                }
                // the result should be negative
                 return -number;
            }


            if (frequency[0] > 0)
            {
                // k identify the first non-zero digit
                 var k = 1;
                // for positive number we will add the first non-zero digit
                // example 403025-> 200345
                 while (frequency[k] == 0)
                 {
                     k++;
                     continue;
                 }
                number = k;
                frequency[k]--;
            }

            for (var i = 0; i < 10; i++)
            {
                while (frequency[i] > 0)
                {
                    number = number * 10 + i;
                    frequency[i]--;
                }
            }

            return number;
        }

        /// <summary>
        /// Q1: Smallest Value of the Re-arranged Number
        /// Example of input: arr = [1, 2, 4, 3, 1, 4, 5, 1, 2]
        /// Solution: Count Sort for negative and positive numbers
        ///     - create a frequency array
        ///     - loop through the frequency array and replace the elements in the original array
        ///       with the index of the frequency array
        ///     - keep counter for index of the original array
        ///     
        /// Remark: this solution will work only for positive numbers
        /// T.C = O(n)
        /// S.C = O(1)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int[] SmallestNumberPositiveDigits(int[] array)
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
        /// Q2: Smallest Value of the Re-arranged Number
        /// Example of input: arr = [-2, 3, 8, 3, -1, 3]
        /// Solution: Count Sort for negative and positive numbers
        ///     - create a frequency nums: identify length of frequency array based on the max and min values
        ///         length = max - min + 1
        ///     - loop through the frequency nums and replace the elements in the original nums
        ///       with the index of the frequency nums
        ///     - keep counter for index of the original nums
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int[] SmallestNumberWithNegative(int[] array)
        {
            var min = int.MaxValue;
            var max = int.MinValue;

            for (var i = 0; i < array.Length; i++)
            {
                min = Math.Min(min, array[i]);
                max = Math.Max(max, array[i]);
            }

            var n = max - min + 1;
            var frequency = new int[n];
            for (var i = 0; i < array.Length; i++)
            {
                frequency[array[i] - min]++;
            }

            var k = 0;
            for (var i = min; i <= max; i++)
            {
                for (var j = 0; j < frequency[i - min]; j++)
                {
                    array[k] = i;
                    k++;
                }
            }

            return array;
        }

        /// <summary>
        /// Q3
        /// Merge all email inbox in chronological order
        /// Solution:
        ///     - this problem is similar to merging 2 sorted arrays problem
        ///     - depending on the input given the implementation may vary 
        ///     - 
        /// Practice similar at Source: https://leetcode.com/problems/merge-sorted-nums/
        /// T.C = O(num)
        /// S.C = O(1)
        /// </summary>
        /// <param name="mailbox1"></param>
        /// <param name="mailbox2"></param>
        /// <returns></returns>
        public int[] MergeAllInboxEmails(int[] mailbox1, int[] mailbox2)
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
        /// Practice similar Source: https://leetcode.com/problems/sort-nums-by-parity-ii/
        /// Solution: 
        ///     - we will create 2 lists for odd and even numbers
        ///     - we will use 2 pointers to iterate over the arr
        ///     - we will add the elements to the original arr in the order 
        /// T.C = O(n)
        /// S.C = O(n)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int[] SortArray(int[] arr)
        {
            var odd = new List<int>();
            var even = new List<int>();

            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    even.Add(arr[i]);
                else
                    odd.Add(arr[i]);
            }

            var k = 0;
            var o = 0;
            var e = 0;
            while (o < odd.Count && e < even.Count)
            {
                //condition to change in letcode practice similar
                //if (k % 2 == 1)
                    if (odd[o] < even[e])
                    {
                        arr[k] = odd[o];
                        k++;
                        o++;
                    }
                    else
                    {
                        arr[k] = even[e];
                        k++;
                        e++;
                    }
            }

            while (o < odd.Count)
            {
                arr[k] = odd[o];
                k++;
                o++;
            }

            while (e < even.Count)
            {
                arr[k] = even[e];
                k++;
                e++;
            }

            return arr;
        }

        /// <summary>
        /// Merge Sort
        /// T.C = O(nlog(n))
        /// S.C = O(n)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public void MergeSort(int[] arr, int left, int right)
        {
            if (left == right)
                return;

            if (left < right)
            {
                var mid = left + (right - left) / 2;
                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }

        /// <summary>
        /// Merge function splits the array in 2 parts
        /// and merges them in sorted order
        /// T.C = O(n)
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="left"></param>
        /// <param name="mid"></param>
        /// <param name="right"></param>
        public void Merge(int[] arr, int left, int mid, int right)
        {
            var n1 = mid - left + 1;
            var n2 = right - mid;

            var L = new int[n1];
            var R = new int[n2];

            for (var i = 0; i < n1; i++)
            {
                L[i] = arr[left + i];
            }

            for (var j = 0; j < n2; j++)
            {
                R[j] = arr[mid + 1 + j];
            }

            var k = left;
            var i1 = 0;
            var i2 = 0;

            while (i1 < n1 && i2 < n2)
            {
                if (L[i1] <= R[i2])
                {
                    arr[k] = L[i1];
                    i1++;
                }
                else
                {
                    arr[k] = R[i2];
                    i2++;
                }
                k++;
            }

            while (i1 < n1)
            {
                arr[k] = L[i1];
                i1++;
                k++;
            }

            while (i2 < n2)
            {
                arr[k] = R[i2];
                i2++;
                k++;
            }
        }
    }
}
