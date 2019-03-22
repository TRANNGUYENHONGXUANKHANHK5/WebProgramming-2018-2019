function lexicographicallyCompare(array) {
    var a = array[0];
    var b = array[1];
    console.log((a > b) ? '>' : ((a < b) ? '<' : '='));
}