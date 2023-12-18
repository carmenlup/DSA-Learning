// Given a number A. Return 1 if A is prime and return 0 if not. 

// Note : 
// The value of A can cross the range of Integer.

function IsPrime(A){
  if(A=== 1) return 0;
  for(let i=2;  i*i <= A; i++){
    if(A % i === 0) return 0 
  }
    return 1
}
console.log(IsPrime(3))

