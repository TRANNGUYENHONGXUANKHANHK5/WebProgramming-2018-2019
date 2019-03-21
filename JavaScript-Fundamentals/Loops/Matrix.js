function solve(args) {
    var n = document.getElementById("myNumber").value;
    var result = "";
    for (var i = 1; i <= n; i++) {
        
        for (var j = 1; j <= n; j++) {
            result += (i + j - 1);
        }
        result += "<br>";
    }
    document.getElementById("res2").innerHTML = result;
}