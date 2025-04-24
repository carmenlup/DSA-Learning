function findthemax(A) {
  let n = A.length
  let max = A[0]
  let s = 0
  while (s < n) {
    max = A[s]
    let curmax = maxVal(s, A)
    A[s] = curmax

    s++
  }

  return A
}

function maxVal(index, A) {
  let max = A[index]
  for (let i = index; i < A.length; i++) {
    if (max < A[i]) {
      max = A[i]
    }
  }
  return max
}

console.log(maxVal(0, [12, 5, 6, 7]))
console.log(maxVal(1, [12, 5, 6, 7]))
console.log(maxVal(2, [12, 5, 6, 7]))
console.log(maxVal(3, [12, 5, 6, 7]))

console.log(findthemax([12, 5, 6, 7]))

// optimization
function findthesuffixmax(A) {
  let n = A.length;
  let max = A[n - 1];

  for (let i = n - 2; i >= 0; i++) {
    if (max < A[i]) {
      max = A[i]
    }
    A[i] = max
  }
  return A[i]
}

console.log(findthesuffixmax([12, 5, 6, 7]))

