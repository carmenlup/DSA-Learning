// Insertion sort
/// <summary>
/// Insertion sort: this is how human brain works in arranging cards in order when playing cards
/// Thinking of the solution
///     - Choose a pivot and shift all values greater than pivot to right
///     - update the pivot to the next value 
///     - repeat the process till the array is sorted
/// B.C => omega(n)
/// W.c. => O(n^2)
/// A.C => O(n^2)
/// 
/// </summary>

function insertionSort(arr) {
  for (let i = 1; i < arr.length; i++) {
    let current = arr[i];
    console.log(current);
    // arr[j + 1] = arr[j];
    // arr[j + 1] = current;
    // let temp = arr[i];
    // arr[i] = arr[minIndex];
    // arr[minIndex] = temp;
    let j = i - 1;
    while (j >= 0 && arr[j] > current) {
      arr[j + 1] = arr[j];
      j--;
    }
    arr[j + 1] = current;
    console.log(arr);
  }
  return arr;
}
console.log(insertionSort([5, 3, 8, 4, 2]));