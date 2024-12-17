// add a console with I am learning JS today

console.log("I am learning JS today")

// variable types
// var are function scoped
var name = "Carmen"
var age = 25;
console.log(name, age);

// set new value to name
name = "Carmen Lup";
// redeclare name
var name = "New value";
//they are hoisted to the top of the function


// let
// const

//functions
function fuc() {
    console.log("I am inside of function");
}

function random() {
    if(true) {
        var x = 10;
    }
    console.log(x);
}

random();