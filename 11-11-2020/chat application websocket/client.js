
const connection=new WebSocket("ws://localhost:8080");
const button=document.querySelector("#send");

connection.onopen=(event)=>{
    console.log("connection opened");
    alert("connection opened");

};

connection.onclose=(event)=>{
console.log("connection is closed");
alert("connection closed");

};

connection.onerror=(event)=>{
console.log("some error occured",event);
alert("error occoured",event);
};

connection.onmessage=(event)=>{
    const chat=document.querySelector("#chat");
    chat.innerHTML+=event.data;

}


button.addEventListener("click",()=>{
const name=document.querySelector("#name");
const message=document.querySelector("#message");
const data=`<p>${name.value} : ${message.value} </p>`;
connection.send(data);

name.value="";
message.value="";

});