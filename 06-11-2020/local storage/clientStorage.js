console.log('client side here');
localStorage.setItem('1','sahil');
localStorage.setItem('2','chandan');
localStorage.setItem('3','sanny')
var name=localStorage.getItem('2');
console.log(name)
localStorage.removeItem('3');
let impArray=["tea","cofee","wine"];
localStorage.setItem('drinks',JSON.stringify(impArray));
 var op=JSON.parse( localStorage.getItem('drinks'));
 console.log(op);