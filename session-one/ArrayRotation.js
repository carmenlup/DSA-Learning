// Given an integer array A of size N and an integer B, you have to return the same array after rotating it B times towards the right.

function reverse(arr, s,e) {
  for(let i = s; i <= e/ 2; i++){
    let temp = arr[i];
    arr[i] = arr[e -i];
    arr[e -i] = temp;
    console.log(arr);
  }
  return arr;
}

// console.log(reverse([1,2,3,4,5], 0,4));

function ReverseArr(arr ,k){
 console.log(reverse(arr, 0, arr.length -1))
 console.log((reverse(arr, 0, k-1)))
 console.log(reverse(arr, k, arr.length -1))
 return arr;
}

console.log(ReverseArr([1,2,3,4,5]));


