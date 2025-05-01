// Rotated Sorted Array Search


function searchInRotatedArray(A, B) {
  let n = A.length
  let l = 0;
  let r = n - 1

  while (l <= r) {
    let mid = Math.floor(l + (r - l) / 2);
    if (A[mid] === B) {
      return mid
    }
    // 4,5,6,7,0,1,2;  B=5 
    if (A[l] <= A[mid]) { // check left side
      if (B >= A[l] && B <= A[mid]) { // check if target is in interval of left to mid
        r = mid - 1
      } else {
        // 4,5,6,7,0,1,2 B=1
        l = mid + 1
      }
    } else {
      // 7,0,1,2,4,5,6; B=4
      if (B >= A[mid] && B <= A[r]) { // check right side
        l = mid + 1
      } else {
        // 7,0,1,3   b=7
        r = mid - 1
      }
    }
  }

}

// console.log(searchInRotatedArray([4, 5, 6, 7, 0, 1, 2], 5)) // 1
// console.log(searchInRotatedArray([4, 5, 6, 7, 0, 1, 2], 1)) // 4
console.log(searchInRotatedArray([7, 0, 1, 2, 4, 5, 6], 7))
// console.log(searchInRotatedArray([7, 0, 1, 3], 7))

