
function findequal(arr){
  let psum = []
  psum[0] = arr[0]
  for(let i = 1; i < arr.length; i++){
    psum[i] = psum[i - 1] + arr[i]
  }
  console.log(psum)

  let L;
  let R;
  let c= 0
  for(let j = 0; j < arr.length; j++){
    if(j === 0 ){
      L= 0
    }else{
      L = psum[j - 1]
    }
    R = psum[arr.length - 1] - psum[j]
    if (L === R){
      c = c + 1;
    }
  }
  return c
}

console.log(findequal([-3,2,4,-1]))
console.log(findequal([-7,1,5,2,-4,3,0]))