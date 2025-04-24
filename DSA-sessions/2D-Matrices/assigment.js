function sumandlen(A, B, C) {
  let n = A.length;
  let sum = BigInt(0);
  let s = 0;
  let e = B - 1
  for (let i = s; i <= e; i++) {
    sum = sum + BigInt(A[i])
  }

  if (sum === BigInt(C)) {
    return 1
  }
  s++
  e++


  for (let i = s; i <= n - e + 1 && i < n; i++) {
    sum = sum - BigInt(A[i - 1]) + BigInt(A[e])
    if (sum === BigInt(C)) {
      return 1
    }
    e++
  }
  return 0
}

console.log(sumandlen([5], 1, 6))


function sumoflengthB(A, B, C) {
  let n = A.length;
  let sum = BigInt(0);
  let s = 0;
  let e = B - 1
  for (let i = 0; i < B; i++) {
    sum = sum + BigInt(A[i])
  }

  if (sum === BigInt(C)) {
    return 1
  }

  for (let i = e; i < n; i++) {
    sum = sum - BigInt(A[i - e]) + BigInt(A[i])
    if (sum === BigInt(C)) {
      return 1
    }
  }
  return 0
}

console.log(sumoflengthB([6, 4, 9, 5, 6, 1, 9], 7, 9))


// provblem 3 spiral printing
process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', function (inputStdin) {
  inputString += inputStdin;
});

process.stdin.on('end', function () {
  inputString = inputString.trim().split('\n');
  main();
});

function readLine() {
  return inputString[currentLine++];
}

function main() {
  let n = parseInt(readLine());
  let matrix = [];

  for (let i = 0; i < n; i++) {
    matrix.push(readLine().split(' ').map(Number));
  }

  printSpiral(matrix, n);
}

function printSpiral(matrix, n) {
  let result = [];
  let left = 0, right = n - 1, top = 0, bottom = n - 1;

  while (left <= right && top <= bottom) {
    for (let i = left; i <= right; i++) {
      result.push(matrix[top][i]);
    }
    top++;

    for (let i = top; i <= bottom; i++) {
      result.push(matrix[i][right]);
    }
    right--;

    if (top <= bottom) {
      for (let i = right; i >= left; i--) {
        result.push(matrix[bottom][i]);
      }
      bottom--;
    }

    if (left <= right) {
      for (let i = bottom; i >= top; i--) {
        result.push(matrix[i][left]);
      }
      left++;
    }
  }

  console.log(result.join(' '));
}