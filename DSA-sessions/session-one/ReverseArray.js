// Given an array A of N integers and also given two integers B and C. Reverse the elements of the array A within the given inclusive range [B, C].

// T.C ->
// S.C ->
function ReverseArray(arr, b, c){
  for (let i = 0 ; i <= arr.length; i++) {
    if(i < b){
       continue
    }
    if(i > c ){
      break
    }

    // this is no needed because of the condition above (i > c)
    //if(b > c)
      //break
    
    let temp = arr[b]
    arr[b] = arr[c]
    arr[c] = temp
    b++;
    c--;
  }

  // while(b < c){
  //  let result = arr[b];
  //   arr[b] = arr[c]
  //   arr[c] = result
  //   b++;
  //   c--;
  // } 
  return arr
}

console.log(ReverseArray([1,2,3,4,5,6,7,8,9,10],3,7));