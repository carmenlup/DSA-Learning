// selection sort algorithm
/// <summary>
/// Selection sort 
/// Thinking on the approach:
///     - the idea is to find each time the index of the min value  
///     - place the min val it at the beginning by swapping with the current element
///     - after swapping the current element becomes the min value and is at its right position
///     - continue the process till the array is sorted
/// B.C, W.C, T.C = O(n^2)
/// Number of operations:
///     n * (n - 1) / 2 to find the min value
///     k swaps where k is the number of swaps
///     - the number of swaps is less than n

function selectionSort(arr) {
  let minIndex;

  for (let i = 0; i < arr.length; i++) {
    minIndex = i;
    console.log(minIndex)
    for (let j = i + 1; j < arr.length; j++) {
      if (arr[j] < arr[minIndex]) {
        minIndex = j;
      }
    }
    // if(minIndex !== i){
    let temp = arr[i];
    arr[i] = arr[minIndex];
    arr[minIndex] = temp;
    console.log(arr);
    // }
  }
  return arr;
}

console.log(selectionSort([5, 3, 8, 4, 2]));

