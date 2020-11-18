var array;
array = [1, 2, 3, 4, 5, 'hello', false];
array.forEach(function (element) {
    console.log(element + " by for each");
});
for (var item in array) {
    console.log(item + " by for in");
}
for (var _i = 0, array_1 = array; _i < array_1.length; _i++) {
    var item = array_1[_i];
    console.log(item + " by for of");
}
array.push("some thing pushed");
var x;
x = ['touple', 2];
array.push(x); //push on last and returns new length of array
var a = [20, 30, 40];
var getLength = array.push(a);
console.log("length of new arr is: " + getLength);
for (var _a = 0, array_2 = array; _a < array_2.length; _a++) {
    var item = array_2[_a];
    console.log(item + " by for of");
}
var popElement = array.pop(); //pops last element and returns that
console.log(popElement);
//concat()
var bl = [100, 200, 300];
var newArray = array.concat(bl);
console.log(newArray);
//join()
var str = array.join('|');
console.log(str);
//shift()
var firstElement = array.shift();
console.log("firstElement is :", firstElement);
//slice()
var sliceArray = array.slice(0, array.length);
console.log(sliceArray);
//sort()
var sortedArray = array.sort(); // ascending order
console.log(sortedArray);
function compareFunc(a, b) {
    if (a > b)
        return -1;
    else if (a < b)
        return 1;
    else
        return 0;
}
var sortedArray2 = array.sort(compareFunc); // descending ord.
console.log('sort by compare function');
console.log(sortedArray2);
//splice()
var deletedItems = array.splice(0, 2, ['one', 'two', 'three']);
console.log(deletedItems);
console.log(array);
//slice()
console.log(array.slice(0, 1));
console.log(array);
//every()
function isGreat(element, index, arr) {
    return (element > 1);
}
var satisfyingCondition;
satisfyingCondition = array.every(isGreat);
console.log(satisfyingCondition);
//some()
var myIndex = -1;
function isTrueOrNot(val, index, array) {
    return array[index] > 0;
}
console.log(array.some(isTrueOrNot));
//map()
function myMap(value, index, array) {
    if (typeof array[index] === "number") {
        array[index] = array[index] * array[index];
        return array;
    }
}
var mappedArray = array.map(myMap);
console.log(mappedArray);
