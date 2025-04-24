// Find even number from L TO R in arr[n] with Q queries;

function countEven(arr, q){
  let result = []
  for(let i = 0; i < q.length; i++){
    let count= 0;
    let L= q[i][0]
    let R= q[i][1]
    for(let j = L; j <= R; j++ ){
      if(arr[j] % 2 == 0){
        count++
      }
      
    }
    result.push(count)
  }
  return result
}
console.log(countEven([2,4,3,7,9,8,6,3,4,9], [[4,8], [3,9], [2,7], [0,4]]))


// Optimal
function countevenInQuery(arr, q){
  let result = [];

  for(let i = 0; i < arr.length; i++){  // O(N)
    if(arr[i] % 2 === 0){
      arr[i] = 1
    } else{
      arr[i] = 0
    }
  }
  
  let psum = [] 
  psum[0] = arr[0];
  for(let i = 1; i < arr.length; i++){  // O(N)
    psum[i] =  psum[i - 1] + arr[i]
    
  }

  // iterate over the range and get the count
  let L;
  let R;
  for(let j = 0; j < q.length; j++){ // o(Q)
    let count = 0
      L=  q[j][0]
      R= q[j][1]
      
    if(L == 0){
        count = psum[R]
      }else{
        count = psum[R] - psum[L-1]
      }
      result.push(count)
  }
  return result
}
 //T.C = O(N+Q)
 // S.C = O(N)
 
console.log(countevenInQuery([2,4,3,7,9,8,6,3,4,9], [[4,8], [3,9], [2,7], [0,4]]))

console.log(countevenInQuery([1,12,3,6,9,8,20,30], [[3,7], [1,5], [2,4], [0,6]]))