// 1. declaration and execution
// function declaration
function fun() {
    console.log("function declaration and execution");
}
// function invocation 
fun();

function serveDrink(serveDrink) {
    console.log(serveDrink);
}
// function invocation 
serveDrink("coffee");

// 2. function expression
// function expression
const fun1 = function() {
    console.log("function expression");
}
// function invocation
fun1();

// 3. arrow function
// arrow function
const fun2 = () => {
    console.log("arrow function");
}
// function invocation
fun2();

// 4. arrow function with one line
// arrow function with one line
const fun3 = () => console.log("arrow function with one line");
// function invocation
fun3();

// 5. arrow function with one argument
// arrow function with one argument
const fun4 = name => console.log(`My name is ${name}`);
// function invocation
fun4("Carmen");

// 6. return a function from a function
// return a function from a function
function returnFun() {
    return function() {
        console.log("return a function from a function");
    }
}
// function invocation
let x = returnFun();
x();

// 7. pass function as an argument
// pass function as an argument
function add(a, b) {
    return a + b;
}

function averrage(a, b,fun) {
    fun(a/b)/2;
}
// function invocation
var averrage = averrage(10, 5, add);
console.log('pass function to a function',averrage);

// 8. typeof function is a function
console.log(typeof fun);
console.log(typeof averrage);