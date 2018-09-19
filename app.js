
fibonacci(30); //warmup

for (var i = 10; i < 50; i += 5) {
    var start = Date.now();
    fibonacci(i)
    var duration = Date.now() - start;
    console.log(i, " => ", duration);
}

function fibonacci(number) {
    if (number == 0) { return 0; }
    else if (number == 1) { return 1; }
    else {
        var t1 = fibonacci(number - 1);
        var t2 = fibonacci(number - 2);
        return t1 + t2;
    }
}