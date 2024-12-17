using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Algorithms.Assignment
{
    public class Session7SubArraysAssignment
    {

        public long LeastAvgSubArraySum(int[] input, int k)
        {
            var n = input.Length;
            long sum = 0;
            //var avg = long.MaxValue;
            var min = long.MaxValue;
            var s = 0;
            var e = k - 1;
            for (var i = 0; i < k; i++)
            {
                sum += input[i];
            }
            //avg = sum / k;
            min = sum;
            s++;
            e++;
            while (e < n)
            {
                sum = sum - input[s - 1] + input[e];
                //avg = sum / k;
                if (min > sum)
                {
                    min = sum;
                }
                s++;
                e++;
            }

            return min/k;
        }
        //function solve(A, B)
        //{
        //    let n = A.length;
        //    let sum = BigInt(0);
        //    let avg = 9007199254740990n
        //    let min = 9007199254740990n
        //    let max = -9007199254740991n
        //    let s = 0;
        //    let e = B - 1
        //    for (let i = 0; i < B; i++)
        //    {
        //        sum = sum + BigInt(A[i])
        //        console.log(sum)
        //    }
        //    avg = sum / BigInt(B)
        //    console.log(avg)

        //    s++
        //    e++
        //    while (e < n)
        //    {
        //        sum = sum - BigInt(A[s - 1]) + BigInt(A[e])
        //        console.log(sum)
        //        avg = sum / BigInt(B)
        //        console.log(avg)
        //        if (min > avg)
        //        {
        //            min = avg
        //        }
        //        s++
        //        e++
        //    }
        //    console.log(min)
        //    return Number(min)
        //}

        // console.log(solve([18,11,16,19,11,9,8,15,3,10,9,20,1,19], 1))

        //console.log(solve([222, 482, 318, 341, 462, 191, 117, 129, 493, 473, 123, 106, 212, 214, 471, 446, 452, 299, 327, 39, 373, 386, 402, 333, 341, 79, 112, 257, 491, 33, 175, 67, 475, 388, 362, 249, 366, 38, 153, 287, 365, 375, 448, 355, 400, 117, 35, 84, 277, 323, 441, 338, 441, 200, 273, 315, 326, 71, 321, 217, 101, 364, 271, 252, 448, 300, 188], 40))

        public int CountSwap(int[] input, int k)
        {
            var n = input.Length;
            var count = 0;
            for (var i = 0; i < n; i++)
            {
                var index = 0;

                if (input[i] > k)
                {
                    // if (input[i] == 1)
                    // {
                    index = i;
                    // }
                }
                else
                {
                    continue;
                }

                for (var j = i + 1; j < n; j++)
                {
                    if (input[j] < k)
                    {
                        var temp = input[j];
                        input[j] = input[index];
                        input[index] = temp;
                        count++;
                        break;
                    }

                    
                }
            }

            return count;
        }

        //function solve(A, B)
        //{
        //    let n = A.length
        //    let count = 0
        //    for (let i = 0; i < n; i++)
        //    {
        //        let index = 0


        //        if (A[i] > B)
        //        {
        //            console.log(A[i] > B)


        //            if (A[i] === 1)
        //            {
        //                console.log(true)
        //            }
        //            index = i
        //            console.log(index)
        //        }
        //        else
        //        {
        //            // console.log(A[i])
        //            if (i === 1)
        //            {
        //                console.log('not')
        //            }
        //            continue
        //        }
        //        for (let j = i + 1; j < n; j++)
        //        {
        //            console.log(j)
        //            if (A[j] < B)
        //            {
        //                console.log(i)
        //                console.log(A[j])
        //                console.log(A[index])
        //                console.log(index)

        //                let temp = A[j]
        //                A[j] = A[index]
        //                A[index] = temp
        //                count++
        //            }
        //            console.log(A)
        //            break
        //        }
        //    }
        //    return count;
        //}


        //console.log(solve([1, 12, 10, 3, 14, 10, 5], 8))
        //        }

        //        s++
        //        e++
        //    }
        //    return maxVal;
        //}


        //function mincountswap(A, B)
        //{
        //    let n = A.length
        //    let index = 0
        //    let count = 0
        //    for (let i = n - 1; i > 0; i--)
        //    {
        //        console.log(i)
        //        while (B < A[i])
        //        {
        //            continue
        //        }
        //        if (A[i] < B)
        //        {
        //            let temp = A[i]
        //            A[i] = A[index]
        //            A[index] = temp
        //            count++
        //            index++
        //            while (A[i] < B)
        //            {
        //                index++
        //            }
        //        }
        //    }
        //    console.log(count)
        //    return count;
        //}
        public int MinSwapMoves(int[] input, int k)
        {
            var n = input.Length;
            var index = 0;
            var count = 0;
            var left = 0;
            var right = input.Length - 1;

            //while (left < right)
            //{
            //    while (input[left] <= k && left < right)
            //    {
            //        left++;
            //    }

            //    while (input[right] > k && left < right)
            //    {
            //        right--;
            //    }

            //    if (left > right)
            //    {
            //        break;
            //    }

            //    if (input[right] <= k && input[left] > k)
            //    {
            //        var temp = input[left];
            //        input[left] = input[right];
            //        input[right] = temp;
            //        count++;
            //    }
            //}



            //public int MinSwapMoves(int[] input, int k)
           // {
                //var n = input.Length;
                //var index = 0;
                //var count = 0;
                for (var i = n - 1; i > 0; i--)
                {
                    if (index > i)
                    {
                        break;
                    }

                    if (input[i] <= k)
                    {
                        var temp = input[i];
                        input[i] = input[index];
                        input[index] = temp;

                        while (input[index] < k)
                        {
                            index++;
                            i--;
                        }
                        count++;
                    }
                }

                return count;
            //}
        }


        public int CountAllChocolate(int[] input, int k)
        {
            var n = input.Length;
            var count = 0;
            for (var i = 0; i < n; i++)
            {
                var index = 0;

                if (input[i] > k)
                {
                    index = i;
                }
                else
                {
                    continue;
                }

                for (var j = i + 1; j < n; j++)
                {
                    if (input[j] <= k)
                    {
                        var temp = input[j];
                        input[j] = input[index];
                        input[index] = temp;
                        count++;
                        break;
                    }
                }
            }

            return count;
        }

        //public int /*function*/ minSwap(int[] arr, int k)
        //{
        //    let snowBallSize = 0;

        //    for (let i = 0; i < n; i++)
        //    {

        //        // Calculating the size of window required
        //        if (arr[i] <= k)
        //        {
        //            snowBallSize++;
        //        }
        //    }

        //    let swap = 0, ans_swaps = Number.MAX_VALUE;

        //    for (let i = 0; i < snowBallSize; i++)
        //    {
        //        if (arr[i] > k)
        //        {
        //            swap++;
        //        }
        //    }

        //    ans_swaps = Math.min(ans_swaps, swap);

        //    for (let i = snowBallSize; i < n; i++)
        //    {
        //        // Checking in every window no. of swaps
        //        // required and storing its minimum
        //        if (arr[i - snowBallSize] <= k && arr[i] > k)
        //            swap++;
        //        else if (arr[i - snowBallSize] > k
        //                 && arr[i] <= k)
        //            swap--;
        //        ans_swaps = Math.min(ans_swaps, swap);
        //    }

        //    return ans_swaps;
        //}
    }
}
