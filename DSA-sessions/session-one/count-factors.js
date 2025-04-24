// Given an integer A, you need to find the count of it's factors.

// Factor of a number is the number which divides it perfectly leaving no remainder.

// Example : 1, 2, 3, 6 are factors of 6


  // function countFactor(A){
  //   let count = 0;
  //   for(let i = 1; i<= A; i++){
  //     if(A % i === 0){
  //       count++;
  //     }
  //   }
  //   return count;
  // }

  // console.log(countFactor(4))


  function countFactor(N){
    let count = 0;
    for(let i=1; i*i <= N; i++){
      if(N % i == 0) {
        if(i*i == N){  
          count++;
        }
        else{
          count += 2;
        }
      }
    }
    return count;
  }

  console.log(countFactor(50))

  //4= 1,2,4  //  1=4 ,2 
  //8= 1,2,4,8
  // 25= 1,5,25
  // 50= 1=50, 2=25, 5=10,
