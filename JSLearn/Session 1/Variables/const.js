// add a console with I am learning JS today

console.log("I am learning JS today")

// variable types
// let
const name = "Carmen"
const age = 25;
console.log(name, age)

// set a new value to name will give an error at runtime
name = "Carmen Lup";
// redeclare name will give an error
// let name = "New value";

//functions
function fuc() {
    console.log("I am inside of function");
}

//1. let and const are block scoped
//2. nerest of where is defined
//3. x cannot be access outside of the block where is declaared
function random() {
    if(true) {
        let x = 10;
    }
    console.log(x);
}

random();