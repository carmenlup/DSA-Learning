/*
* Session 1 - Introduction to problem solving
*/

// reverse an array of n elements
function reverseArray(arr){
    const length = arr.length - 1;
    for(let i = 0; i < length / 2; i++)
    {
        let temp = arr[i];
        arr[i] = arr[length - i];
        arr[length - i] = temp;
    }
    
    return arr;
}

console.log(reverseArray([1,2,3,4,5]));

// generic function to reverse an array
function reverse(arr, s, e)
{
    const length = arr.length - 1;
    for(let i = s; i < e; i++)
    {
        let temp = arr[i];
        arr[i] = arr[length - i];
        arr[length - i] = temp;
    }

    return arr;
}

console.log(reverse([1,2,3,4,5], 1, 3));

//reverse a subarray of k elements in a array from a given index
function reverseSubarray(arr, k, s)
{
    k = s + k - 1;
    if(k > arr.length)
        k == arr.length;

    reverse(arr, s, k);
    return arr;
}

console.log(reverseSubarray([1,2,3,4,5], 3, 1));