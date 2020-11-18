x = findMax(1, 123, 500, 115, 44, 88);
console.log(x)
function findMax() {
  var i;
  var max = -Infinity;
  for (i = 0; i < arguments.length; i++) {
    if (arguments[i] > max) {
      max = arguments[i];
    }
  }
  return max;
}
function myFunction(a, b) {
    return a * b;
  }
  myFunction(10, 2);    

// call by call() method
var person = {
    fullName: function() {
      return this.firstName + " " + this.lastName;
    }
  }
  var person1 = {
    firstName:"John",
    lastName: "Doe"
  }
  var person2 = {
    firstName:"Mary",
    lastName: "Doe"
  }

  console.log(person.fullName.call(person1)); 
  console.log(person.fullName.call(person2));

  var student = {
    Details: function() {
      return this.Name + " " + this.Marks;
    }
  }
  var Student1 = {
    Name:"Jerry",
    Marks: "90"
  }
  
  console.log(student.Details.apply(Student1));
  console.log(student.Details.apply(Student1,["hi","everyone"]));
 
  

 