function myUpperCase() {
    var x = document.getElementById("fname");
    x.value = x.value.toUpperCase();
  }

  function mySelect() {
    alert("You have selected some text!");
}
function myChange() {
    var x = document.getElementById("mySelect").value;
    document.getElementById("change").innerHTML = "You selected: " + x;
  }
  function mySubmit() {
    alert("The form was submitted");
  }
  function myKeyDown() {
    alert("You pressed a key inside the input field");
  }
  function myKeyPress() {
    alert("You pressed a key inside the input field");
  }
  function myKeyPress() {
    alert("You pressed a key inside the input field");
  }
  function myDBClick(){
     document.getElementById("db").innerHTML="I will appear when you double click on the button";
  }
