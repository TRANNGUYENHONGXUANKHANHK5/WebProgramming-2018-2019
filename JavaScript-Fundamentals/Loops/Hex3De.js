function solve(args) {
    var n = document.getElementById("myNumber").value;
    var result = 0, digitValue;
    hex = n.toLowerCase();
    for (var i = 0; i < hex.length; i++) {
        digitValue = '0123456789abcdefgh'.indexOf(hex[i]);
        result = result * 16 + digitValue;
    }
    document.getElementById("res2").innerHTML = result;
}