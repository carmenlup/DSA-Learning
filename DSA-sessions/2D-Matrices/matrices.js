// Given arr[n], return Max subarray sum of length = K

function maxSubarraySum(arr, k) {
  let n = arr.length;
  let sum = 0;
  let max = 0;
  let s = 0;
  let e = k - 1
  for (let i = s; i < k; i++) {
    sum = sum + arr[i]
  }

  max = sum;
  s++
  e++

  for (let i = e; i < n; i++) {
    sum = sum - arr[i - e] + arr[i]

    if (max < sum) {
      max = sum
    }

  }

  return max

}

console.log(maxSubarraySum([-3, 4, -2, 5, 3, -2, 8, 2, -1, 4], 5))
//7,8,12,16,10,11


// Given mat[n][n], print boundary in clockwise direction.

// when we move from left to right the column index will increase.  
// when we move from top to bottom the row will increase.
// when we move right to left column index will decrease
// when we move from bottom to top the row index will decrease.

function printClockwiseDirection(mat) {
  let n = mat.length;
  console.log(n)
  let row = 0;
  let col = 0

  if (n === 1) {
    console.log(mat[row][col])
  }
  for (let i = 1; i < n; i++) {
    console.log(mat[row][col])
    col++
  }

  for (let i = 1; i < n; i++) {
    console.log(mat[row][col])
    row++
  }
  for (let i = 1; i < n; i++) {
    console.log(mat[row][col])
    col--
  }
  for (let i = 1; i < n; i++) {
    console.log(mat[row][col])
    row--
  }

}

console.log(printClockwiseDirection([[1, 2, 3, 4, 5], [6, 7, 8, 9, 10], [11, 12, 13, 14, 15], [16, 17, 18, 19, 20], [21, 22, 23, 24, 25]]))


// Spiral printing.

function spiralPrinting(mat) {
  let n = mat.length;
  let r = 0
  let c = 0
  while (n > 1) {

    for (let i = 1; i < n; i++) {
      console.log(mat[r][c])
      c++
    }
    for (let i = 1; i < n; i++) {
      console.log(mat[r][c])
      r++
    }
    for (let i = 1; i < n; i++) {
      console.log(mat[r][c])
      c--
    }
    for (let i = 1; i < n; i++) {
      console.log(mat[r][c])
      r--
    }

    n = n - 2
  }

  if (n === 1) {
    console.log(mat[r][c])
  }
}

console.log(spiralPrinting([[1, 2, 3, 4, 5], [6, 7, 8, 9, 10], [11, 12, 13, 14, 15], [16, 17, 18, 19, 20], [21, 22, 23, 24, 25]]))


// given rowwise, column wise started matrix[N][M], find K?

function findtheK(mat, k) {
  let n = mat.length;
  let r = 0;
  let c = n - 1;
  for (let i = 1; i < n; i++) {
    if (k === mat[r][c]) {
      console.log(mat[r][c])
      return true
    }
    if (k > mat[r][c]) {
      console.log(mat[r][c])
      r++
    }
    if (k < mat[r][c]) {
      console.log(mat[r][c])
      c--
    }
  }
  return false
}

console.log(findtheK([[-10, -5, -2, 2, 4, 7], [-7, -4, -1, 3, 6, 9], [-2, 3, 5, 7, 11, 14], [3, 6, 8, 11, 14, 17], [7, 11, 12, 15, 19, 20], [10, 14, 18, 20, 24, 29]], 11))