function findSubarraySumWithValueC(A, B, C) {
  let n = A.length;
  let s = 0;
  let e = B - 1;
  let sum = BigInt(0)

  for (let i = s; i < e; i++) {
    sum = sum + BigInt(A[i])
  }
  if (sum === BigInt(C)) {
    return 1
  }

  s++
  e++
  for (let j = s; j < e; j++) {
    sum = sum - BigInt(A[s - 1]) + BigInt(A[e])
    console.log(sum)
    if (sum === BigInt(C)) {
      return 1
    }
  }
  return 0

}

console.log(findSubarraySumWithValueC([4, 3, 2, 6, 1], 3, 11))



function findMaxSumOfSubarrayLengthB(A, B) {
  let n = A.length;
  let s = 0;
  let e = B - 1;
  let sum = BigInt(0);
  let maxVal = 0;
  for (let i = s; i <= e; i++) {
    sum = sum + BigInt(A[i])
    console.log(sum)
  }

  maxVal = sum
  s++
  e++

  while (e < n) {
    sum = sum - BigInt(A[s - 1]) + BigInt(A[e])

    if (maxVal < sum) {
      maxVal = sum
    }

    s++
    e++
  }
  return maxVal;
}

let test = findMaxSumOfSubarrayLengthB([3, 2, 21, 21, 17, 13, 6, 28, 9], 9)

console.log(test)


// Given an array A of size N, find the subarray of size B with the least average.
/*
Problem Constraints
1 <= B <= N <= 105
-105 <= A[i] <= 105 
*/


//param A : array of integers
//param B : integer
//return an integer
function solve(A, B) {
  let n = A.length;
  let sum = BigInt(0);

  let minSum = BigInt(0);
  let minIndex = 0;

  let s = 0;
  let e = B - 1

  for (let i = 0; i < B; i++) {
    sum = sum + BigInt(A[i])
    console.log(sum)
  }

  minSum = sum

  console.log(sum)
  console.log(minSum)

  s++
  e++

  while (e < n) {
    sum = sum - BigInt(A[s - 1]) + BigInt(A[e])
    console.log(sum)

    if (minSum > sum) {
      minSum = sum

      console.log(minSum)

      minIndex = s

      console.log(minIndex)
    }


    s++
    e++
  }
  console.log(minIndex)
  return minIndex

  // let n = A.length;

  // if (B > n) {
  //   throw new Error("B cannot be larger than the array size");
  // }

  // let sum = BigInt(0);
  // let minSum = BigInt(0);
  // let minIndex = 0;

  // // Calculate the sum of the first subarray of size B
  // for (let i = 0; i < B; i++) {
  //   sum += BigInt(A[i]);
  //   // console.log(sum)
  // }
  // console.log(sum)

  // minSum = sum;

  // console.log(minSum)

  // // Iterate through the rest of the array using sliding window
  // for (let i = B; i < n; i++) {
  //   sum = sum - BigInt(A[i - B]) + BigInt(A[i]);

  //   console.log(i)
  //   console.log(B)
  //   console.log(i-B)
  //   if (sum < minSum) {

  //     minSum = sum;
  //     console.log(minSum)
  //     minIndex = i - B + 1;
  //     console.log(minIndex)
  //   }
  // }
  // console.log(minIndex)
  // return minIndex;
}

// console.log(solve([3, 7, 90, 20, 10, 50, 40], 3))
// console.log(solve([0, 0, 0, -1, -1, -1, -1, -1], 3))

// console.log(solve([222, 482, 318, 341, 462, 191, 117, 129, 493, 473, 123, 106, 212, 214, 471, 446, 452, 299, 327, 39, 373, 386, 402, 333, 341, 79, 112, 257, 491, 33, 175, 67, 475, 388, 362, 249, 366, 38, 153, 287, 365, 375, 448, 355, 400, 117, 35, 84, 277, 323, 441, 338, 441, 200, 273, 315, 326, 71, 321, 217, 101, 364, 271, 252, 448, 300, 188], 40))






function countSwap(A, B) {
  let n = A.length
  let count = 0
  for (let i = 0; i < n; i++) {
    let index = 0

    if (A[i] > B) {
      // console.log(A[i] > B)


      index = i
      console.log(index)
    } else {
      console.log(A[i])

      continue
    }
    for (let j = i + 1; j < n; j++) {
      // console.log(j)
      if (A[j] < B) {

        let temp = A[j]
        A[j] = A[index]
        A[index] = temp
        count++
        break
      }
      console.log(A)
    }
  }
  console.log(count)
  return count;
}


// console.log(countSwap([52, 7, 93, 47, 68, 26, 51, 44, 5, 41, 88, 19, 78, 38, 17, 13, 24, 74, 92, 5, 84, 27, 48, 49, 37, 59, 3, 56, 79, 26, 55, 60, 16, 83, 63, 40, 55, 9, 96, 29, 7, 22, 27, 74, 78, 38, 11, 65, 29, 52, 36, 21, 94, 46, 52, 47, 87, 33, 87, 70], 19))


function mincountswap(A, B) {
  let n = A.length
  let index = 0
  let count = 0
  for (let i = n - 1; i > 0; i--) {
    console.log(i)
    if (index > i) {
      break
    }

    if (A[i] < B) {
      let temp = A[i]
      A[i] = A[index]
      A[index] = temp
      index++
      while (A[index] < B) {
        index++
        i--
      }
      count++
    }
  }
  console.log(count)
  return count;
}


// console.log(mincountswap([52, 7, 93, 47, 68, 26, 51, 44, 5, 41, 88, 19, 78, 38, 17, 13, 24, 74, 92, 5, 84, 27, 48, 49, 37, 59, 3, 56, 79, 26, 55, 60, 16, 83, 63, 40, 55, 9, 96, 29, 7, 22, 27, 74, 78, 38, 11, 65, 29, 52, 36, 21, 94, 46, 52, 47, 87, 33, 87, 70], 19))


function mincountslidingwindow(A, B) {
  let n = A.length;
  let windowCount = 0;

  for (let i = 0; i < n; i++) {
    if (A[i] <= B) {
      windowCount++;
    }
  }
  console.log(windowCount)
  let s = 0
  let e = windowCount
  let count = 0;
  let minSwap = 0

  if (windowCount === 0) {
    return 0;
  }

  for (let i = s; i < e; i++) {
    if (A[i] > B) {
      count++
    }
  }
  console.log(count)


  minSwap = count

  let count1 = 1
  let arr = []
  for (let i = 140 - 43 + 1; i <= 140; i++) {
    arr.push(A[i])
  }
  console.log(arr)

  for (let i = e; i < n; i++) {
    count1++

    if (A[i - e] > B) {
      count--;
    }


    if (A[i] > B) {
      count++
    }

    console.log(count, count1)
    if (count < minSwap) {
      minSwap = count
    }

  }

  return minSwap;
}

console.log(mincountslidingwindow([2255, 6353, 7832, 9990, 516, 9853, 7018, 3337, 3008, 6158, 679, 2954, 2024, 2807, 1944, 6596, 7992, 2942, 9355, 788, 65, 2966, 9276, 1064, 1112, 6197, 4615, 8140, 30, 478, 5360, 7585, 8853, 9481, 1099, 8781, 9514, 4603, 8209, 7455, 5225, 6740, 4734, 4942, 4475, 4995, 4086, 6448, 1408, 2446, 4675, 92, 4942, 7421, 6302, 8226, 431, 2463, 5762, 2681, 1877, 2121, 3450, 5930, 9743, 5045, 9977, 906, 9293, 5441, 6825, 3244, 7021, 3910, 7866, 1013, 8227, 7926, 9226, 8710, 7088, 7761, 3413, 4200, 1671, 4526, 9890, 9594, 257, 3212, 8341, 9641, 2060, 5072, 2776, 4084, 4988, 501, 4304, 3685, 5424, 5713, 7920, 3115, 187, 3915, 3971, 7755, 8802, 4439, 8104, 5610, 5007, 1348, 4449, 9993, 17, 6395, 5539, 3415, 6500, 9899, 9049, 8197, 1419, 7112, 5823, 4739, 7975, 6915, 5852, 4072, 1694, 4353, 8867, 7362, 3410, 8415, 4060, 1353, 2342, 1712, 9038, 5421, 5772, 9291, 1611, 2822, 7927, 9644, 9236, 6052, 9592, 2206, 28, 3772, 1694, 2085, 6137, 4683, 655, 4604, 4979, 1948, 661, 9333, 6319, 257, 8146, 5744, 3533, 6508, 6792, 338, 5507, 4191, 7116, 8174, 1577, 1045, 3337, 86, 5667, 9341, 1606, 558, 7382, 8198, 7954, 225, 7154, 7780, 1290, 1269, 9782, 5909, 6713, 3605, 5672, 8661, 6988, 4669, 1954, 7852, 5580, 5893, 6242, 9970, 2892, 4471, 4272, 3072, 8475, 9925, 8930, 442, 5873, 1128, 2204, 2384, 3532, 970, 3543, 448, 4699, 2630, 7742, 1563, 1626, 3552, 3030, 3124, 4535, 650, 5330, 3862, 3799, 3011, 7809, 9538, 4567, 6431, 5775, 6903, 6675, 7459, 5750, 4193, 9102, 3352, 4107, 1483, 7454, 8293, 5044, 9638, 4995, 5558, 9882, 2316, 2614, 9934, 9669, 1486, 762, 4598, 883, 3279, 6893, 1958, 9703, 7636, 5217, 8460, 3711, 2173, 1677, 9273, 1191, 7967, 6001, 9935, 7241, 2552, 4373, 8518, 2801, 3310, 839, 3715, 7410, 2663, 2894, 1335, 8993, 4987, 6888, 4139, 4324, 4024], 1732))