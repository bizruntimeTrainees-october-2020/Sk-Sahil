//export{};
function greeter(person:string) {
    return "Hello, " + person;
  }
  
  let user = "Jane User";
  
  document.body.textContent = greeter(user);

  //interface


  interface Guy{
      firstName:string;
      lastName:string;

  }

  function greet(guy:Guy){
      return "Hello "+guy.firstName+" "+guy.lastName+" user";
  }

  let user1={firstName:"Marie", lastName:"Jane"};
  document.body.textContent=greet(user1);

  //type

//   let decimal: number = 6;
// let hex: number = 0xf00d;
// let binary: number = 0b1010;
// let octal: number = 0o744;

//array,touple,unknown type

let list:number[];
list=[3,2,1];
for(let i=0;i<list.length;i++){
    console.log(i); var gf=2;
}
for(let i in list)
{
console.log(i+"i");
}
for(let i of list)
{
    console.log(i+"of");

}
list.forEach(ele=>{
    console.log(ele);
})

list.push(1);
list.pop();
list.find(a=>{
    a==1;
})
list.includes(1);
list.indexOf(1);
list.splice(0,length);
delete list[1];



console.log(gf);

list.forEach(element => {
    console.log(element);
    
});

let x: [string, number];
 x= ["hello", 7];

console.log(x[0].substring(1,3));

//unknown type
let notSure: unknown = 4;
notSure = "maybe a string instead";
console.log(typeof notSure);

notSure=false;
console.log(typeof notSure);


//interface

interface LabeledValue {
    label: string;
  }
  
  function printLabel(labeledObj: LabeledValue) {
    console.log(labeledObj.label);
  }
  
  let myObj = {  label: "Size 10 Object" };
  printLabel(myObj);

//type assertion

let bizRun;
bizRun="company";

(<string>bizRun).length; //process-1

(bizRun as string).length;  //pro-2


//interface

interface Namepro{
    firstName:string;
    lastName:string;
}
let names=(namepro:Namepro)=>{
    console.log(namepro.firstName);
    console.log(namepro.lastName);
}

names({
    firstName:"Sk",
    lastName:"Sahil"
});


