let socket=new WebSocket("wss://javascript.info/article/websocket/demo/hello");

socket.onopen=function () {
    alert("[open] Connection established");
  alert("Sending to server");
  socket.send("My name is Sahil");
};
socket.onmessage=function (event) {
    alert(`[message] Data received from server: ${event.data}`);
};

socket.onclose=function (event) {
    if (event.wasClean) {
        alert(`[close] connection closed , code=${event.code} & reason=${event.reason}`)
    }
    else{
        alert('[close] Connection died');
    }
        
    }

    socket.onerror=function (event) {
        alert(`[error] ${event.error}`)
    }

