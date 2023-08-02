"Use strict";
var conneciton = new SignalR.HubConnectionBuilder().withUrl("/notificationHub").build();
connection.start();
conneciton.on("ReceicveMsg", funciton(msg) {
    var li = document.createElement("li");
    li.textContext = msg;
    document.getElementById("msgList").appendChild(li);
});

/*var connection = new signalR.HubConnectionBuilder()
    .withUrl("/myHub")
    .build();

connection.on("ReceiveMessage", function (user, message) {
    // Handle the received message here
});

connection.start().then(function () {
    // Connection is established, and you can start invoking server-side methods
}).catch(function (err) {
    console.error(err.toString());
});*/