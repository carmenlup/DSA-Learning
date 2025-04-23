// Given a binary array nums, return the maximum number of consecutive 1's in the array.
// https://leetcode.com/explore/featured/card/fun-with-arrays/521/introduction/3238/


// var count = 0;
// var maxCount = -1;
// for (var i = 0; i < nums.Length; i++)
// {
//     if (nums[i] == 1)
//         count++;

//     if (maxCount < count)
//         maxCount = count;

//     if (nums[i] != 1)
//         count = 0;
// }

// return maxCount;
let findMaxConsecutiveOnes = function (nums) {

  let n = nums.length;
  let count = 0
  let max = 0;
  for (let i = 0; i < n; i++) {

    if (nums[i] === 1) {
      count++
    }

    if (nums[i] === 0 || i === n - 1) {
      if (max < count) {
        max = count
        count = 0

      }
    }
  }
  return max;

};

console.log(findMaxConsecutiveOnes([1, 1, 1, 1, 1, 1, 1]))