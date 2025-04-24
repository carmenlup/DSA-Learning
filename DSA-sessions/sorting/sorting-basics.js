// sorting the array based on magnitutde in dsc order.
// LINK:-  https://leetcode.com/problems/find-minimum-cost-to-remove-array-elements/description/

const arr = [3, 5, 1, -3];

function sortArray(arr) {
  arr.sort((a, b) => b - a);
  let sum = 0
  for (let i = 0; i < arr.length; i++) {
    sum += (i + 1) * arr[i]
  }
  return sum;
}
console.log(sortArray(arr));

//  Find the noble number
//  A noble number is a number whose value is equal to the number of elements greater than it.
//  Given an array of integers, find the noble number in the array.

// LINK:- https://www.interviewbit.com/problems/noble-integer/

// Brute force approach
function findNobleNumber(arr) {
  let nobleNumber = 0;
  for (let i = 0; i < arr.length; i++) {
    let count = 0;
    for (let j = 0; j < arr.length; j++) {
      if (arr[i] > arr[j]) {
        count++;
      }
    }
    console.log(count)
    console.log(arr[i])
    if (arr[i] === count) {
      nobleNumber++
    }
  }
  return nobleNumber
}
// T.C: O(n^2)
// S.C: O(1)
console.log(findNobleNumber([-3, 0, 2, 5]));

//  Optimized approach
//  1. Sort the array in non-increasing order.

function findNobleNumber2(arr) {
  arr.sort((a, b) => a - b)
  let nobleNumber = 0;
  for (let i = 0; i < arr.length; i++) {
    if (arr[i] === i) {


      nobleNumber++;
    }
  }
  return nobleNumber;
}

console.log(findNobleNumber2([1, -5, 3, 5, -10, 4]));
// T.C: O(nlogn)
// S.C: O(1)



//HOMEWORK  Link:- https://leetcode.com/problems/count-of-smaller-numbers-after-self/description/   


// Find the noble number with repeating elements
// 1. Sort the array in non-increasing order.
// 2. Traverse the array and count the number of elements greater than the current element.
// 3. If the current element is equal to the count, return the current element.
// 4. If the current element is equal to the next element, continue to the next element.

function findNobleNumber3(arr) {
  arr.sort((a, b) => a - b)
  let count = 0;
  let nobleNumber = 0;
  if (arr[0] === 0) {
    nobleNumber++;
  }

  for (let i = 0; i < arr.length; i++) {
    if (arr[i] !== arr[i - 1]) {
      count = i;
    }
    if (arr[i] === arr[i - 1]) {
      continue;
    }
    console.log(count)
    console.log(arr[i])
    if (count === arr[i]) {
      nobleNumber++
    }
    // count = 0
    console.log(nobleNumber)
  }
  return nobleNumber;
}
console.log(findNobleNumber3([-3, 0, 2, 2, 5, 5, 5, 5, 8, 8, 10, 10, 10, 14]));
// console.log(findNobleNumber3([-10,1,1,3,100]));