// Given an integer array A of size N and an integer B, you have to return the same array after rotating it B times towards the right.

function reverse(arr, s,e) {
     while(s < e) {
      let temp = arr[s]
      arr[s] = arr[e]
      arr[e] = temp
      s++
      e--
    } 
    return arr  
  }

function ReverseArray(arr, k)
{
    
    reverse(arr, 0, arr.length - 1)
   // console.log(arr)
    reverse(arr, 0, k - 1)
   // console.log(arr)
    reverse(arr, k, arr.length - 1)
   // console.log(arr)
    return arr;
}

console.log(ReverseArray([1,2,3,4,5], 2));


