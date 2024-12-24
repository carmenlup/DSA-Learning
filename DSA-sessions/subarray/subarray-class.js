// Given an array with start index and end index. print subarray.

function printSubarray(arr, s, e) {
  for (let i = s; i <= e; i++) {
    console.log(arr[i])
  }
}

console.log(printSubarray([1, 2, 3, 4], 1, 3))


function printSubarrayByLength(arr, s, l) {
  let e = l + s - 1;
  for (let i = s; i <= e; i++) {
    console.log(arr[i])
  }
}

console.log(printSubarrayByLength([1, 2, 3, 4, 5, 7, 8], 4, 2))



//count of subarray

function countofsubarraybyindex(arr, s) {
  let c = 0;
  for (let i = s; i < arr.length; i++) {
    c = c + 1
  }
  return c
}

console.log(countofsubarraybyindex([4, 2, 10, 3, 12, -2, 15], 1))


// total count of subarrays?

function totalCountOfSubarray(arr) {
  for (let s = 0; s < arr.length; s++) {
    let count = 0;
    for (let e = s; e < arr.length; e++) {
      for (let i = s; i <= e; i++) {
        count = count + 1
      }
    }
    return count
  }
}

console.log(totalCountOfSubarray([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21]))


function totalcountofsubarrayoptimal(arr) {
  let n = arr.length
  let count = n * (n + 1) / 2;
  return count;
}

console.log(totalcountofsubarrayoptimal([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21]))

// Print each subarray in new line

function printSubInNewLine(arr) {
  let allsubarray = [];
  for (let s = 0; s < arr.length; s++) {
    for (let e = s; e < arr.length; e++) {
      let result = []
      for (let i = s; i <= e; i++) {
        result.push(arr[i])
      }
      console.log(result)
      allsubarray.push(result)
    }
  }
  return allsubarray
}

console.log(printSubInNewLine([2, 8, -1, 4]))


// print each subarrays sum in new line

function calculateTheSubarray(arr) {
  let result = [];
  for (let s = 0; s < arr.length; s++) {
    for (let e = s; e < arr.length; e++) {
      let sum = 0;
      for (let i = s; i <= e; i++) {
        sum = sum + arr[i];
      }
      result.push(sum)
      console.log(sum);
    }
  }
  return result;
}

console.log(calculateTheSubarray([2, 8, -1, 4]))

// with psum

function calculatTheSubarrayWithPsum(arr) {
  let n = arr.length;
  let psum = []
  psum[0] = arr[0]
  for (let i = 1; i < n; i++) {
    psum[i] = psum[i - 1] + arr[i]
  }
  let sum = 0
  let result = []
  for (let s = 0; s < n; s++) {
    for (let e = s; e < n; e++) {
      if (s === 0) {
        sum = psum[e]
      } else {
        sum = psum[e] - psum[s - 1]
      }
      result.push(sum)
    }
  }
  return result;
}

console.log(calculatTheSubarrayWithPsum([2, 8, -1, 4]))


// print subarray sum starting from index 3

function subarraySumByIndex(arr, s) {
  let n = arr.length;
  let result = []
  let sum = 0
  for (let e = s; e < n; e++) {
    sum = sum + arr[e]
    result.push(sum)
    console.log(sum)
  }
  return result
}

console.log(subarraySumByIndex([3, 8, 4, 7, 9, 4, 3, 2, 10, 6], 3))

