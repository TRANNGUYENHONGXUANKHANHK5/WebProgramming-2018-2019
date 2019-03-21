function solve(args) {
    var i, n;
    var max = 0;
    var min = 0;
    var sum = 0;
    var avg = 0;

    n = parseInt(prompt("Enter array size"));
    var a = new Array(n);

    for (i = 0; i < n; i++) {
        a[i] = parseInt(prompt("Enter numbers"));
    }
    max = a[0];
    for (i = 1; i < n; i++) {
        if (max < a[i])
            max = a[i];
    }
    min = a[0];
    for (i = 1; i < n; i++) {
        if (min > a[i])
            min = a[i];
    }
    sum = 0;
    for (i = 0; i < n; i++) {
        sum = sum + a[i];
    }

    avg = sum / n;

    document.write("Array Elements : – ");
    for (i = 0; i < n; i++) {
        document.write(a[i] +" ");
    }

    document.write("<br>" +"Maximumr = "+max + "<br>");
    document.write("Minimum Number = "+min +"<br>");
    document.write("Sum of Array Numbers= " + sum + "<br>");
    document.write("Average= " + avg + "<br>");
}