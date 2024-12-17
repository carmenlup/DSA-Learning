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


function minSwap(arr, n, k){
  let snowBallSize = 0;
   
  for(let i = 0; i < n; i++)
  {
   
      // Calculating the size of window required
      if (arr[i] <= k) {
          snowBallSize++;
      }
  }
   
  let swap = 0, ans_swaps = Number.MAX_VALUE;
   
  for(let i = 0; i < snowBallSize; i++){
      if (arr[i] > k){
          swap++;
      }
  }
   
  ans_swaps = Math.min(ans_swaps, swap);
   
  for(let i = snowBallSize; i < n; i++){
      // Checking in every window no. of swaps
      // required and storing its minimum
      if (arr[i - snowBallSize] <= k && arr[i] > k)
          swap++;
      else if (arr[i - snowBallSize] > k
               && arr[i] <= k)
          swap--;
      ans_swaps = Math.min(ans_swaps, swap);
  }
   
  return ans_swaps;
}


function minSwap(arr, k){
  let windowSize = 0;
  let n = arr.length;

  for(let i = 0; i < n; i++)
  {
      // Calculating the size of window required
      if (arr[i] <= k) {
        windowSize++;
      }
  }
   
  let swap = 0, minSwaps = Number.MAX_VALUE;
  minSwaps = windowSize;
  for(let i = 0; i < windowSize; i++){
      if (arr[i] > k){
          swap++;
      }
  }
   
  minSwaps = Math.min(minSwaps, swap);
   
  for(let i = snowBallSize; i < n; i++){
      // Checking in every window no. of swaps
      // required and storing its minimum
      if (arr[i - snowBallSize] <= k && arr[i] > k)
          swap++;
      else if (arr[i - snowBallSize] > k
               && arr[i] <= k)
          swap--;
      ans_swaps = Math.min(ans_swaps, swap);
  }
   
  return ans_swaps;
}