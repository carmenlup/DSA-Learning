// count factors

function countFactors(A) {
  let count = 0
  for (let i = 1; i <= A; i++) {
    if (A % i === 0) {
      count++
    }
  }
  return count
}

console.log(countFactors(12))

// 6= 2*3
// 12 = 

// optimization
function countF(N) {
  let count = 0;
  for (let i = 1; i * i <= N; i++) {
    if (N % i === 0) {

      if (i * i === N) {
        count += 1
      } else {
        count += 2
      }
    }
  }
  return count
}

console.log(countF(6))
// HOMEWORK==> PRINT ALL FACTORS OF A NUMBER.

// Given a number A. Return 1 if A is prime and return 0 if not. 
// Note : 
// The value of A can cross the range of Integer.

function isPrime(A) {
  let count = 0

  if (A <= 1) return 0; // 0 and 1 are not prime numbers

  for (let i = 1; i * i <= A; i++) {
    if (A % i === 0) {

      if (i * i === A) {
        count += 1
      }
      else {
        count += 2
      }
      if (count > 2) {
        return 0
      }
    }
  }
  // if (count === 2) {
  //   return 1
  // }
  return 1
}

console.log(isPrime(1))


// You will be given an integer n. You need to return the count of prime numbers less than or equal to n.

function countPrimes(n) {
  let count = 0
  for (let i = 2; i <= n; i++) {
    if (isPrime(i)) {
      count++
    }
  }
  return count
}

console.log(countPrimes(13))