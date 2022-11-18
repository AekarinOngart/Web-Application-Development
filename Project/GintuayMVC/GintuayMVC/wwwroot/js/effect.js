// navbar controll
function showoff(id) {
    for (i = 1; i <= id.length; i++) {
        var x = document.getElementById(id[i - 1]);
        console.log(x.style.display)
        if (x.style.display == "block") {
            x.style.display = "none";
        }
    }

}

window.onscroll = function () { scrollFunction() };
function scrollFunction() {
    showoff(['menu', 'menu1'])
    if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
        document.getElementById(id).style.top = "0";
    } else {
        document.getElementById(id).style.top = "-50px";
    }
}

function show(id) {
    showoff(['menu', 'menu1'])
    var x = document.getElementById(id);
    console.log(x.style.display)
    if (x.style.display == "none") {
        x.style.display = "block";
    } else if (x.style.display == "") {
        x.style.display = "block"
    } else {
        x.style.display = "none"
    }
}
function show1(id) {
    showoff(['menu', 'menu1'])
    var x = document.getElementById(id);
    console.log(x.style.display)
    if (x.style.display == "none") {
        x.style.display = "block";
    } else if (x.style.display == "") {
        x.style.display = "block"
    } else {
        x.style.display = "none"
    }
}

//pop-up
document.getElementById("pop").onclick = popup1;
document.getElementById("pay").onclick = popup2;

function popup1() {
    document.querySelector(".popup1").style.display = "block";
    document.querySelector("#close").addEventListener("click", function () {
        document.querySelector(".popup1").style.display = "none";
    });
}

function popup2() {
    document.querySelector(".popup1").style.display = "none";
    document.querySelector(".popup2").style.display = "block";
    document
        .querySelector("#close2")
        .addEventListener("click", function () {
            document.querySelector(".popup2").style.display = "none";
        });
}