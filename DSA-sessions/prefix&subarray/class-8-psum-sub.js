// Array query (zero query)
// bruteforce aproach
function arrayQuerry(arr, q) {
  let n = arr.length;
  let ans = arr;
  // console.log(ans)

  for (let i = 0; i < q.length; i++) {
    for (let j = q[i][0]; j < n; j++) {
      ans[j] = ans[j] + q[i][1]
    }
  }
  return ans
}
// TC= O(Q * N)
// SC= O(1)

console.log(arrayQuerry([0, 0, 0, 0, 0, 0, 0], [[1, 3], [4, -2], [3, 1]]))



// pfsum approach:-

function arrayQueryWithPfsum(arr, q) {
  let n = arr.length;
  let ans = arr


  for (let i = 0; i < q.length; i++) {
    let index = q[i][0]
    let value = q[i][1]
    ans[index] = value + ans[index]


    console.log(index)
    console.log(value)
    console.log(ans[index])
    console.log(arr[i])
    console.log(ans[i])
  }

  // let psum = []
  // psum[0] = ans[0]

  // for(let j = 1; j < n; j++ ){
  //   psum[j] = psum[j -1] + ans[j]
  // }
  // console.log(psum)

  // this replace pfsum:- we started from 1 because answer has its initial value on 0 index.
  for (let j = 1; j < ans.length; j++) {
    ans[j] = ans[j - 1] + ans[j]
  }

  return ans
}

console.log(arrayQueryWithPfsum([0, 0, 0, 0, 0, 0, 0], [[1, 3], [4, -2], [3, 1]]))



// Array Query with Start and end.

function arrQueryWithStartandEnd(arr, q) {
  let n = arr.length;
  let ans = arr;

  for (let i = 0; i < q.length; i++) {
    let s = q[i][0]
    let e = q[i][1]
    let val = q[i][2]
    console.log(s, e, val)

    for (let j = s; j <= e; j++) {
      ans[j] = ans[j] + val
    }
    console.log(ans)
  }

  return ans
}

//  TC= Q * N   SC= N
console.log(arrQueryWithStartandEnd([0, 0, 0, 0, 0, 0, 0], [[1, 3, 2], [2, 5, 3], [2, 4, -1], [3, 6, 2]]))

// Pfsum approach:-
function arrarrQueryWithStartandEndwithPsum(arr, q) {
  let n = arr.length;
  let ans = arr;

  for (let i = 0; i < q.length; i++) {
    let s = q[i][0];
    let e = q[i][1];
    let val = q[i][2];
    if (e < n - 1) { //n-1 is not included because we want to fill up next index
      ans[e + 1] = ans[e + 1] - val
    }
    ans[s] = val + ans[s]

    // console.log(ans[s],ans[e+1])
    // console.log(ans)
  }
  // console.log(ans)

  // let psum = [];
  // psum[0] = ans[0]

  // for (let j = 1; j < ans.length; j++) {
  //   psum[j] = psum[j - 1] + ans[j] // 
  // }
  // console.log(psum)

  for (let i = 1; i < ans.length; i++) {
    ans[i] = ans[i - 1] + ans[i];
  }

  return ans
}

// TC = O(q+n) SC = O(N)
console.log(arrarrQueryWithStartandEndwithPsum([0, 0, 0, 0, 0, 0, 0], [[1, 3, 2], [2, 5, 3], [2, 4, -1], [3, 6, 2]]))



//Q1- There are A beggars sitting in a row outside a temple. Each beggar initially has an empty pot. When the devotees come to the temple, they donate some amount of coins to these beggars. Each devotee gives a fixed amount of coin(according to their faith and ability) to some K beggars sitting next to each other.

// Given the amount P donated by each devotee to the beggars ranging from L to R index, where 1 <= L <= R <= A, find out the final amount of money in each beggar's pot at the end of the day, provided they don't fill their pots by any other means.
// For ith devotee B[i][0] = L, B[i][1] = R, B[i][2] = P, given by the 2D array B


function beggerMoneySum(A, B) {
  let n = A
  let ans = []
  // ans[0] = 0
  for (let i = 0; i < A; i++) {
    ans[i] = 0
    console.log(ans)
  }
  // console.log('ans',ans)
  for (let i = 0; i < B.length; i++) {
    let L = B[i][0]
    let R = B[i][1]
    let P = B[i][2]
    console.log(L)
    console.log(R)
    console.log(P)

    if (R < n) {
      ans[R] = ans[R] - P
      console.log(ans[R] - P)
    }
    ans[L - 1] = ans[L - 1] + P
    console.log(ans)
  }
  for (let i = 1; i < ans.length; i++) {
    ans[i] = ans[i] + ans[i - 1]
  }
  return ans

}

console.log(beggerMoneySum(5, [[1, 2, 10], [2, 3, 20], [2, 5, 25]]))