var array: any[];

array=[1,2,3,4,5,'hello',false];

array.forEach(element=>{
    console.log(element+" by for each");
});

for(let item in array){
    console.log(item+" by for in");
}

for(let item of array){
    console.log(item+" by for of");
}

array.push("some thing pushed");

var x:[string,number];
x=['touple',2];

array.push(x); //push on last and returns new length of array
var a=[20,30,40];
let getLength=array.push(a);
console.log("length of new arr is: "+getLength);

for(let item of array){
    console.log(item+" by for of");
}

let popElement=array.pop(); //pops last element and returns that
console.log(popElement);

//concat()

let bl=[100,200,300];
let newArray=array.concat(bl);
console.log(newArray);

//join()

let str=array.join('|');
console.log(str);

//shift()

let firstElement=array.shift();
console.log("firstElement is :" , firstElement);

//slice()

let sliceArray=array.slice(0,array.length);
console.log(sliceArray);

//sort()

let sortedArray=array.sort();// ascending order
console.log(sortedArray);

 function compareFunc(a,b){
     if(a>b) return -1;
     else if (a<b) return 1;
     else return 0;

}
let sortedArray2=array.sort(compareFunc);// descending ord.

console.log('sort by compare function');

console.log(sortedArray2);


//splice()

let deletedItems= array.splice(0,2,['one','two','three']);

console.log(deletedItems);
console.log(array);

//slice()

console.log(array.slice(0,1));

console.log(array);

//every()

function isGreat(element,index,arr){
    return (element>1)
}

let satisfyingCondition:boolean;
satisfyingCondition= array.every(isGreat);
console.log(satisfyingCondition);


//some()
var myIndex=-1;
function isTrueOrNot(val,index,array){
  return array[index]>0;
 }
console.log(array.some(isTrueOrNot));





//map()

function myMap(value,index,array){
    if(typeof array[index]==="number")
 {
    array[index]=array[index]*array[index];
    return array;
 }
    
}

let mappedArray=array.map(myMap);

console.log(mappedArray);

















