// Hashmap is a data structure that stores key-value pairs
// It is also called a dictionary or associative array
// It is used to store data in a way that allows for fast retrieval
// Hashmap is implemented using a hash table

function findFrequencyOfElementsQuery(A, B) {

  let myMap = new Map()
  // add frequency of elements in A to myMap
  for (let i = 0; i < A.length; i++) {
    let key = A[i]
    //those basic operation are set, update, delete, get, has, clear, size, keys, values

    if (myMap.has(key)) {
      console.log(myMap.get(key))
      myMap.set(key, myMap.get(key) + 1)
    } else {
      myMap.set(key, 1)
    }
  }
  // create an array to store the frequency of elements in B
  let result = []
  // iterate through B and get the frequency of each element in myMap
  for (let i = 0; i < B.length; i++) {

    if (myMap.has(B[i])) {
      result.push(myMap.get(B[i]))
    } else {
      result.push(0)
    }
  }

  return result

}

console.log(findFrequencyOfElementsQuery([1, 2, 3, 2, 1, 1], [1, 2, 3]))

function freak(arr) {
  // i'm looking for a datastructure to optimize the space
  // this is hashmap
  //all programming languages have builldin hashmap
  // if i dont use builtin map structure i need to implement the basics operation for my map
  //those basic operation are add, update, delete, get, has, clear, size, keys, values
  let fr = [0, 0, 0, 0, 0, 0, 0, 0]
  let idx = arr[0]
  for (let i = 0; i < arr.length; i++) {
    idx = arr[i]
    fr[idx] = fr[idx] + 1
  }
  return fr
}


console.log(freak([1, 2, 3, 2, 1, 1, 4, 7]))


// Given an array A of N integers, return the number of unique elements in the array.
// An element is considered unique if it appears only once in the array.
// implement using set

function uniqueElements(arr) {
  let mySet = new Set()
  for (let i = 0; i < arr.length; i++) {
    mySet.add(arr[i])
  }
  return mySet.size
}
console.log(uniqueElements([1, 2, 3, 2, 1, 1, 4, 7])) // 5

// given a string s, find the length od the longest substring without repeating characters

function longestSubstring(s) {
  let mySet = new Set()
  let left = 0
  let maxLength = 0
  // left is the start of the substring
  // right is the pointer to establish the end of the substring
  for (let right = 0; right < s.length; right++) {
    while (mySet.has(s[right])) {
      mySet.delete(s[left])
      left++
    }
    mySet.add(s[right])
    maxLength = Math.max(maxLength, right - left + 1)
  }
  return maxLength
}

console.log(longestSubstring("abcabcbb")) // 3