//export{};
function greeter(person) {
    return "Hello, " + person;
}
var user = "Jane User";
document.body.textContent = greeter(user);
function greet(guy) {
    return "Hello " + guy.firstName + " " + guy.lastName + " user";
}
var user1 = { firstName: "Marie", lastName: "Jane" };
document.body.textContent = greet(user1);
//type
//   let decimal: number = 6;
// let hex: number = 0xf00d;
// let binary: number = 0b1010;
// let octal: number = 0o744;
//array,touple,unknown type
var list;
list = [3, 2, 1];
for (var i = 0; i < list.length; i++) {
    console.log(i);
    var gf = 2;
}
for (var i in list) {
    console.log(i + "i");
}
for (var _i = 0, list_1 = list; _i < list_1.length; _i++) {
    var i = list_1[_i];
    console.log(i + "of");
}
list.forEach(function (ele) {
    console.log(ele);
});
list.push(1);
list.pop();
list.find(function (a) {
    a == 1;
});
list.includes(1);
list.indexOf(1);
list.splice(0, length);
delete list[1];
console.log(gf);
list.forEach(function (element) {
    console.log(element);
});
var x;
x = ["hello", 7];
console.log(x[0].substring(1, 3));
//unknown type
var notSure = 4;
notSure = "maybe a string instead";
console.log(typeof notSure);
notSure = false;
console.log(typeof notSure);
function printLabel(labeledObj) {
    console.log(labeledObj.label);
}
var myObj = { label: "Size 10 Object" };
printLabel(myObj);
//type assertion
var bizRun;
bizRun = "company";
bizRun.length; //process-1
bizRun.length; //pro-2
var names = function (namepro) {
    console.log(namepro.firstName);
    console.log(namepro.lastName);
};
names({
    firstName: "Sk",
    lastName: "Sahil"
});
