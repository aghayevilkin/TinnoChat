"use strict";


//document.getElementsByClassName("notif-content-icon")[0].addEventListener("click", function (e) {
//    e.preventDefault();
//    this.nextElementSibling.classList.toggle("show");
//});

let adjustScroll = () => {
    document.getElementsByClassName("cont")[0].scrollTop = (parseInt(document.getElementById("message-box").clientHeight) - 300);
}

if (document.getElementsByClassName("chat-page").length > 0) {
    adjustScroll();
}

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

connection.on("ReceiveMessage", function (message, date, countUp, userId) {
    //jsbdv
    if (countUp) {
        let oldCount = parseInt(document.getElementsByClassName("badge-danger")[0].innerText);
        if (isNaN(oldCount)) {
            document.getElementsByClassName("badge-danger")[0].innerText = 1
        } else {
            document.getElementsByClassName("badge-danger")[0].innerText = (oldCount + 1)
        }
    }

    let friend = document.getElementById("friend-id").value;
    if (userId == friend) {

        var topDiv = document.createElement("div");
        topDiv.classList.add("message-item");
        topDiv.classList.add("in");

        var div = document.createElement("div");
        div.classList.add("message");
        div.classList.add("reciever");
        div.classList.add("message-content");

        var p = document.createElement("div");
        p.classList.add("message-text");
        p.innerText = message;

        let time = date.split("T")[1].substring(0, 5);
        let date2 = date.split("T")[0].split("-")[2] + "." + date.split("T")[0].split("-")[1] + "." + date.split("T")[0].split("-")[0];
        let resultDate = date2 + " " + time;
        var span = document.createElement("div");
        span.classList.add("time");
        span.classList.add("mt-2");
        span.innerText = resultDate;

        topDiv.appendChild(div);
        div.appendChild(p);
        p.appendChild(span);
        document.getElementById("message-box").appendChild(topDiv);

        adjustScroll();
    }
});


connection.on("ChangeActiveStatus", function (isActive, userId) {

    let user = document.getElementById(userId);
    let OnlineOffline = document.getElementById("isActive");

    if (isActive) {
        
        user.classList.add("avatar-state-success");
        OnlineOffline.classList.add("text-success");
        OnlineOffline.classList.remove("text-danger");
        OnlineOffline.innerText = "Online";
        
    }
    else {
        user.classList.remove("avatar-state-success");
        OnlineOffline.classList.remove("text-success");
        OnlineOffline.classList.add("text-danger");
        OnlineOffline.innerText = "Offline";
    }

});



connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    event.preventDefault();

    var friendId = document.getElementById("friend-id").value;
    var message = document.getElementById("message").value;

    connection.invoke("SendMessage", friendId, message).catch(function (err) {
        return console.error(err.toString());
    });


    var topDiv = document.createElement("div");
    topDiv.classList.add("message-item");
    topDiv.classList.add("out");

    var div = document.createElement("div");
    div.classList.add("message");
    div.classList.add("sender");
    div.classList.add("message-content");

    var p = document.createElement("div");
    p.classList.add("message-text");
    p.innerText = message;


    var span = document.createElement("div");
    span.classList.add("time");
    span.classList.add("mt-2");
    var date = new Date();

    //month
    let month = 0;
    if (date.getMonth() + 1 < 10) {
        month = 0 + "" + (date.getMonth() + 1);
    } else {
        month = date.getMonth() + 1
    }

    //hours
    let hours = 0;
    if (date.getHours() < 10) {
        hours = "0" + date.getHours();
    } else {
        hours = date.getHours();
    }

    //minutes
    let minutes = 0;
    if (date.getMinutes() < 10) {
        minutes = "0" + date.getMinutes();
    } else {
        minutes = date.getMinutes();
    }
    span.innerText = date.getDate() + "." + month + "." + date.getFullYear() + " " + hours + ":" + minutes;

    topDiv.appendChild(div);
    div.appendChild(p);
    p.appendChild(span);
    document.getElementById("message-box").appendChild(topDiv);

    document.getElementById("message").value = "";

    adjustScroll();
});

