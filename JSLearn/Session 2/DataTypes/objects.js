let person = {
    name: "Carmen",
    age: 25,
    phone: 1234567890
}

// access object properties
console.log(person.name);
console.log(person.age);
console.log(person.phone);
// undefinde because property does not exist
console.log(person.isMarried);
//let person2 = person;
console.log(person);
person.age++;

var x = 5;
var y = x;
x++;
console.log(x, y); // X = 6, Y = 5

let person2 = {
    name: "Luza",
    age: 30,
    phone: 1222221222
}

person2 = person;
person.age++;
console.log(person2.age);
console.log(person.age);

// complex objects
let captainAmerica = {
    name: "Steve Rogers",
    age: 100,
    alias: ["Tony", "Bruce", "Bucky"],
    // function inside an object
    sayHi : function(){
        console.log('Captain says hi')
    },
    address: {
        city: {
            name: "Brooklyn",
            zip: 11234
        },
        country: "USA"
    }
}
console.log(captainAmerica.name);
console.log(captainAmerica.alias[1]);
//log city name
console.log(captainAmerica.address.city.name);
// calling function defined within an object
console.log(captainAmerica.sayHi());

// add new property to object
captainAmerica.movies = ["The First Avenger", "Winter Soldier", "Civil War"];
console.log(captainAmerica.movies);

// delete property from object
delete captainAmerica.movies;