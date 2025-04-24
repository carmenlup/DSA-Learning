// You are given a constant array A.
// You are required to return another array which is the reversed form of the input array.

function reverse(arr){
  let end = arr.length - 1;
  // arr.length / 2 is working only for the entire array
  for(let i = 0; i < arr.length / 2; i++) {
    let temp = arr[i]
    arr[i] = arr[end - i]
    arr[end -i] = temp
    // console.log(arr)
  }
  return arr
}

console.log(reverse([1,2,3,4,5]))