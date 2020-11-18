//parse() method
var text = '{"employees":[' +
'{"firstName":"John","lastName":"Doe" },' +
'{"firstName":"Anna","lastName":"Smith" },' +
'{"firstName":"Peter","lastName":"Jones" }]}';
obj = JSON.parse(text);
document.getElementById("demo").innerHTML =obj.employees[1].firstName + " " + obj.employees[1].lastName;


// stringify() method
var obj = { name: "John", age: 30, city: "New York" };
var myJSON = JSON.stringify(obj);
document.getElementById("demo1").innerHTML = myJSON;

//json object
var myObj, x;
myObj = {"name":"John", "age":30, "car":null};
x = myObj.name;
document.getElementById("demo2").innerHTML = x;

//json array through loops
var myObj, i, x = "";
myObj = {
  "name":"John",
  "age":30,
  "cars":[ "Ford", "BMW", "Fiat" ]
};
myObj.cars[2]="Rolls Royce"
delete myObj.cars[1];

for (i in myObj.cars) {
  x += myObj.cars[i] + "<br>";
}
document.getElementById("demo3").innerHTML = x;