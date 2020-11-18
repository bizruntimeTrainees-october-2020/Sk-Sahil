document.getElementById("demo").innerHTML = 5 + 6;
console.log("hi");

// class
class Employee  
  {  

    constructor(id,name)  
    {  
      this.id=id;  
      this.name=name;  
    }  

    detail()  
    {  
  console.log(this.id+" "+this.name+"<br>")  
    }  
  }  
 
var e1=new Employee(101,"Martin Roy");  
var e2=new Employee(102,"Duke William");  
e1.detail();
e2.detail();  

// object
emp={id:102,name:"Shyam Kumar",salary:40000}   //by literals
console.log(emp.id+" "+emp.name+" "+emp.salary); 

var emp=new Object();//by new keywords
emp.id=1;
emp.name="Rama";
emp.salary=50000;
console.log("Id="+emp.id+" "+"Employee Name="+emp.name+" "+"salary="+emp.salary+" ");

function student(id,name,marks){  
    this.id=id;  
    this.name=name;  
    this.marks=marks;
    }  
st=new student(23,"jenny",85);     //by  constructor
console.log("Id="+st.id+" "+"student Name="+emp.name+" "+"Marks="+emp.salary+" ");


//prototype
function EmployeeName(firstName,lastName)  
{  
  this.firstName=firstName;  
  this.lastName=lastName;  
}  
  
EmployeeName.prototype.fullName=function()  
  {  
    return this.firstName+" "+this.lastName;  
  }  
  
var employee1=new EmployeeName("Thiago","messi");  
var employee2=new EmployeeName("Lionel", "messi");  
console.log(employee1.fullName());  
console.log(employee2.fullName());  

//variable
var a=5;
var b=7;
console.log(a+b);
console.log(typeof"something");

//functions

function toCelsius(fahrenheit) {
    return (5/9) * (fahrenheit-32);
  }
 var x=toCelsius(77);
 console.log(x);
 console.log(toCelsius);
