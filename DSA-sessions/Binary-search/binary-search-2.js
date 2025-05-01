// Aggresive cows 
// Farmer John has built a new long barn with N stalls. Given an array of integers A of size N where each element of the array represents the location of the stall and an integer B which represents the number of cows.

// His cows don't like this barn layout and become aggressive towards each other once put into a stall. To prevent the cows from hurting each other, John wants to assign the cows to the stalls, such that the minimum distance between any two of them is as large as possible. What is the largest minimum distance?

// LINK:- https://www.interviewbit.com/problems/aggressive-cows/
// Brute force approach
function isCowsPossible(A, B, mid) {
  let cows = 1
  let lastPos = A[0]

  for (let i = 1; i < A.length; i++) {
    if (A[i] - lastPos >= mid) {
      cows++
      lastPos = A[i]
    }
  }
  return cows >= B
}


// Binary search approach
function aggressiveCows(A, B) {
  A.sort((a, b) => a - b)
  let l = 1
  let r = A[A.length - 1] - A[0]
  let ans = -1

  while (l <= r) {
    let mid = Math.floor((l + r) / 2)
    if (isCowsPossible(A, B, mid)) {
      ans = mid
      l = mid + 1
    } else {
      r = mid - 1
    }
  }
  return ans
}



// my code
function solve(A, B) {
  let n = A.length
  let l = 1
  let r = A[n - 1] - A[0]
  let result = 0
  while (l <= r) {
    let mid = Math.floor(l + (r - l) / 2)
    let countCows = mid
    let countCows1 = mid + 1

    if (countCows === B && countCows1 < B) {
      return mid
    }

    // decide left or right
    if (countCows >= B) {
      l = mid + 1
    } else {
      result = mid
      r = mid - 1
    }
  }
  return result

}


// Painters // Given an array of integers A of size N where each element of the array represents the length of a board. You have to paint all the boards using B painters. Each painter takes 1 unit of time to paint 1 unit of board. The problem is that a painter can only paint contiguous sections of the board. The goal is to find the minimum time required to paint all the boards.
// LINK:- https://www.interviewbit.com/problems/painters-partition-problem/
// Brute force approach

// 5,3,6,2,9 dataset
// timeUnit = 2
// totalTime = 20
function countPainters(boards, timeUnit, totalTime) {
  let count = 1;
  let remainingTime = totalTime

  for (let i = 0; i < boards.length; i++) {
    let paintBoardTime = boards[i] * timeUnit

    if (paintBoardTime > totalTime) {
      return -1
    }

    if (paintBoardTime <= remainingTime) {
      remainingTime -= paintBoardTime
    } else {
      count++
      remainingTime = totalTime - paintBoardTime
      // remainingTime -= paintBoardTime
    }
  }
  return count

}

console.log(countPainters([5, 3, 6, 1, 9], 2, 20))


function findMinimumTime(boards, painters, timeUnit) {
  let l = 0
  let r = 0

  let max = Number.MIN_VALUE

  for (let i = 0; i < boards.length; i++) {
    r += boards[i] * timeUnit
    console.log(r)
    let painttime = boards[i] * timeUnit
    if (max < painttime) {
      max = painttime
    }

  }
  l = max
  let result = 0
  while (l <= r) {
    let mid = Math.floor(l + (r - l) / 2)
    let countmid = countPainters(boards, timeUnit, mid)
    let countmidleft = countPainters(boards, timeUnit, mid - 1)

    if (countmid <= painters && countmidleft > painters) {
      return mid % 10000003
    }
    if (countmid <= painters) {
      result = mid % 10000003
      r = mid - 1
    } else {
      l = mid + 1
    }
  }
  return result
}

console.log(findMinimumTime([1000000, 1000000], 1, 1000000)) // 20



// Count Cows

function countCows(arr, D) {
  let count = 1
  let lastCowPos = arr[0]

  for (let i = 1; i < arr.length; i++) {
    if (arr[i] - lastCowPos >= D) {
      count++
      lastCowPos = arr[i]
    }
  }
  return count

}

console.log(countCows([1, 3, 4, 8, 10, 12, 17], 10)) // 2


function findMinimumDistance(A, B) {
  let n = A.length
  let l = 1
  let r = A[n - 1] - A[0]
  let result = 0

  while (l <= r) {
    let mid = Math.floor(l + (r - l) / 2)
    let countCows = countCows(mid)
    let countCows1 = countCows(mid + 1)

    if (countCows === B && countCows1 < B) {
      return mid
    }

    // decide left or right
    if (countCows >= B) {
      l = mid + 1
    } else {
      result = mid
      r = mid - 1
    }
  }
  return result

}

