// Printing all subarray sum

function printAllSubarray(arr) {
  for (let s = 0; s < arr.length; s++) {
    let sum = 0;
    for (let e = s; e < arr.length; e++) {
      // for (let i = s; i <= e; i++) {
      sum = sum + arr[e];
      console.log(sum)
      // }
    }
    return sum
  }
}

console.log(printAllSubarray([3, 4, 2]))

function printAllSubarraysum(arr) {
  let n = arr.length;
  let totalSum = 0;
  for (let s = 0; s < n; s++) {
    let sum = 0;
    for (let e = s; e < n; e++) {
      sum = sum + arr[e]
      console.log(sum)
      totalSum = totalSum + sum;
    }
  }
  return totalSum
}
// TC= O(n2)  Sc= O(1)
console.log(printAllSubarraysum([3, 4, 2]))


// Contribution Technique Optimization===>
function subarraySumBycontribution(arr) {
  let n = arr.length;
  let totalsum = 0

  for (let i = 0; i < n; i++) {
    let contribution = 0;
    let occurrence = (i + 1) * (n - i);

    contribution = occurrence * arr[i];
    console.log(occurrence)
    console.log(contribution)
    totalsum += contribution
  }
  return totalsum;
}
// TC= O(n)  Sc= O(1)

console.log(subarraySumBycontribution([2, 8, -1, 4]))


// Given arr[n], return max subarray sum of length = k

/*
constraints:=
  1 <= N <= 10^5
  1<= K <= N
  -10^6 <= arr[i] <= 10^6
*/

function maxSubarrayofLengthK(arr, k) {
  let n = arr.length;
  let e = k - 1;
  let s = 0;
  let maxValue = Number.MIN_VALUE;

  while (e < n) { // N
    let sum = 0;
    for (let i = s; i <= e; i++) { // K
      sum = sum + arr[i]
      console.log(sum);
    }
    maxValue = Math.max(maxValue, sum)
    console.log(maxValue)
    s++
    e++
  }
  return maxValue;
}

console.log(maxSubarrayofLengthK([-3, 4, -2, 5, 3, -2, 8, 2, -1, 4], 5))


// Approach-2 With Prefixsum ==>
function maxSubarrayofLengthKbyPsum(arr, k) {
  let n = arr.length;
  let psum = [];
  psum[0] = arr[0]

  for (let i = 1; i < n; i++) {
    psum[i] = psum[i - 1] + arr[i]
  }

  let e = k - 1;
  let s = 0;
  let maxvalue = Number.MIN_VALUE;

  while (e < n) {
    if (s === 0) {
      sum = psum[e]
      console.log(sum)

    } else {
      sum = psum[e] - psum[s - 1]
      console.log(sum)
    }
    maxvalue = Math.max(maxvalue, sum)
    console.log(maxvalue)
    s++
    e++
  }
  return maxvalue;
}

console.log(maxSubarrayofLengthKbyPsum([-3, 4, -2, 5, 3, -2, 8, 2, -1, 4], 5))


// Optimisation with Sliding Window + data we store (C.F)=>


function maxSubarrayOfLengthKbySlidingWin(arr, k) {
  let n = arr.length;
  console.log(n)
  let e = k - 1;
  let s = 0;
  let maxValue = Number.MIN_VALUE;
  let sum = 0;

  for (let i = s; i <= e; i++) {
    sum = sum + arr[i]
  }
  maxValue = Math.max(maxValue, sum);

  s++
  e++
  while (e < n) {
    sum = sum - arr[s - 1] + arr[e];
    maxValue = Math.max(maxValue, sum);

    s++
    e++
  }
  console.log(maxValue);
}

maxSubarrayOfLengthKbySlidingWin([-3, 4, -2, 5, 3, -2, 8, 2, -1, 4], 5);



// function maxSubarrayOfLengthKbySlidingWin(arr, k) {
//   let n = arr.length;
//   if (n < k) {
//     return null; // Return null if the array is smaller than the window size
//   }

//   let maxValue = -Infinity;
//   let sum = 0;

//   // Calculate the sum of the first window
//   for (let i = 0; i < k; i++) {
//     sum += arr[i];
//   }
//   maxValue = Math.max(maxValue, sum);

//   // Slide the window through the array
//   for (let i = k; i < n; i++) {
//     sum = sum - arr[i - k] + arr[i];
//     maxValue = Math.max(maxValue, sum);
//   }

//   console.log(maxValue);
//   return maxValue;
// }

// maxSubarrayOfLengthKbySlidingWin([-3, 4, -2, 5, 3, -2, 8, 2, -1, 4], 5);




