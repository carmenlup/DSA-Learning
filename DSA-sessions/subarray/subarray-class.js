// Given an array with start index and end index. print subarray.

function printSubarray(arr, s, e){
    for(let i = s; i <= e; i++){
      console.log(arr[i])
    }
}

console.log(printSubarray([1,2,3,4], 1,3))


function printSubarrayByLength(arr, s, l){
    let e = l + s - 1;
    for(let i = s; i <= e; i++){
      console.log(arr[i])
    }
}

console.log(printSubarrayByLength([1,2,3,4,5,7,8], 4,2))



//count of subarray

function countofsubarraybyindex(arr, s){
  let c = 0;
  for(let i = s; i < arr.length; i++){
    c = c + 1
  }
  return c
}

console.log(countofsubarraybyindex([4,2,10,3,12,-2,15], 1))


// total count of subarrays?

function totalCountOfSubarray(arr){
  for(let s = 0; s < arr.length; s++){
    let count = 0;
    for(let e = s; e < arr.length; e++){
      for(let i = s; i <= e; i++){
        count = count + 1
      }
    }
    return count
  }
}

console.log(totalCountOfSubarray([1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21]))


function totalcountofsubarrayoptimal(arr){
  let n = arr.length
  let count = n*(n+1)/2;
  return count;
}

console.log(totalcountofsubarrayoptimal([1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21]))
