package main

import "fmt"
import "time"

func main() {
   	fibonacci(30) //warmup
   	var i int
	for i = 10; i < 50; i += 5 {
		var start = time.Now()
		fibonacci(i)
		var duration = time.Now().Sub(start)
		fmt.Println(i, " => ", int64(duration) / 1000000)
	}
}

func fibonacci(number int) (ret int) {
	if number == 0 { 
		return 0 
	} else if number == 1 { 
		return 1 
	} else {
        var t1 = fibonacci(number - 1)
        var t2 = fibonacci(number - 2)
		return t1 + t2
	}   
}