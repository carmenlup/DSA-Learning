var person1 = {
    name: "carmen",
    gender: "female",
};

var person2 = {
    name: "anand",
    age: "male",
};

person1 === person2; // false
console.log(person1 === person2);

var person3 = person1;
person1 === person3; // true
person1.name = "carmen lup";
console.log(person3);

