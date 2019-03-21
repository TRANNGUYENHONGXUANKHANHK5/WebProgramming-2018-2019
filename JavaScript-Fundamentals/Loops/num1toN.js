function solve(args) {
    var n = document.getElementById("myNumber").value;
    var text = "";
    for (var i = 1; i <= n; i++) {
        text += i + "<br>";
    }
    document.getElementById("res2").innerHTML = text;
}