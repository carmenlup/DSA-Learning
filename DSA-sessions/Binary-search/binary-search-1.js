const search = function (nums, target) {
  let n = nums.length
  let l = 0;
  let r = n - 1;

  while (l <= r) {
    let mid = Math.floor((l + r) / 2)


    if (nums[mid] === target) {
      return mid
    }
    if (nums[mid] < target) {
      l = mid + 1
    } else {
      r = mid - 1
    }
  }
  return -1

};


console.log(search([9, 2147483647, 2147483647], 9)) // 4





const searchRange = function (A, B) {
  let n = A.length
  let l = 0
  let r = n - 1;
  let result = [-1, -1]

  if (A.length === 1 && A[0] === B) {
    result[0] = 0
    result[1] = 0
    return result
  }

  while (l <= r) {
    let mid = Math.floor((l + r) / 2)
    if (A[mid] === B && (mid === 0 || A[mid - 1] < B)) {
      result[0] = mid
      break
    }
    if (A[mid] >= B) {
      r = mid - 1
    } else {
      l = mid + 1
    }
  }

  l = 0
  r = n - 1;

  while (l <= r) {
    let mid = Math.floor((l + r) / 2)
    if (A[mid] === B && (mid === n - 1 || A[mid + 1] > B)) {
      result[1] = mid
      break
    }
    if (A[mid] > B) {
      r = mid - 1
    } else {
      l = mid + 1
    }
  }

  return result
}

console.log(searchRange([1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 8, 8, 8, 8, 8, 8, 8, 8, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10], 1)) // [3,4]



const searchInsert = function (A, B) {
  let l = 0
  let r = A.length - 1
  let result = 0

  if (B > A[r]) {
    return A.length
  }

  while (l <= r) {
    let mid = Math.floor(l + (r - l) / 2)
    if (A[mid] === B) {
      return mid
    }

    if (A[mid] > B) {
      result = mid
      r = mid - 1
    } else {
      l = mid + 1
    }
  }
  return result

}

console.log(searchInsert([1, 3, 5, 6], 5)) // 2
console.log(searchInsert([1, 3, 5, 6], 7)) // 2
console.log(searchInsert([1, 3, 5, 6], 0)) // 2

// find the local minima 
// local minima is the element which is less than its neighbours

function findminima(arr) {
  let n = arr.length
  let l = 0
  let r = arr.length - 1

  if (arr[0] < arr[1]) {
    return 0
  }
  if (arr[n - 1] < arr[n - 2]) {
    return n - 1
  }

  while (l <= r) {
    let mid = Math.floor(l + (r - l) / 2)
    // 2,1,3 dataset
    if (arr[mid] < arr[mid - 1] && arr[mid] < arr[mid + 1]) {
      return mid
    }

    // 1,2,3
    if (mid > 0 && arr[mid] > arr[mid - 1]) {
      r = mid - 1
    }
    // 3,2,1
    else {
      l = mid + 1
    }
  }
}
console.log(findminima([2, 1, 3])) // 1
console.log(findminima([3, 2, 1])) // 2
console.log(findminima([2, 3, 1])) // 0
console.log(findminima([1, 2, 3, 4, 5])) // 0

function findpeakelement(arr) {
  // 3,1,2
  let n = arr.length
  let l = 0
  let r = arr.length - 1
  let result = 0

  if (arr[0] > arr[1]) {
    return arr[0]
  }
  if (arr[n - 1] > arr[n - 2]) {
    return arr[n - 1]
  }

  while (l <= r) {
    let mid = Math.floor(l + (r - l) / 2)
    // 1,3,2
    if (arr[mid] > arr[mid - 1] && arr[mid] > arr[mid + 1]) {
      return arr[mid]
    }
    // 
    //2,1,3
    if (arr[mid] < arr[mid - 1]) {
      r = mid - 1
    }
    // 3,2,1
    else {
      result = arr[mid]
      l = mid + 1
    }
  }
  return result
}
// console.log(findpeakelement([5,3, 1, 2])) // 0
// console.log(findpeakelement([1, 3, 2,5])) // 1
// console.log(findpeakelement([2, 3, 1])) // 1
console.log(findpeakelement([1, 1000000000, 1000000000]
)) // 0


