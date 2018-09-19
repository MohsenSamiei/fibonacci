import java.util.Date;

public class app {

    public static void main(String[] args) {
        Fibonacci(30); //warmup
        for (int i = 10; i < 50; i+=5)
        {
            var start = new Date();
            Fibonacci(i);
            var duration = new Date().getTime() - start.getTime();
            System.out.println(i + " => " +  duration);
        }
    }

    private static int Fibonacci(int number)
    {
        if (number == 0) { return 0; }
        else if (number == 1) { return 1; }
        else
        {
            var t1 = Fibonacci(number - 1);
            var t2 = Fibonacci(number - 2);
            return t1 + t2;
        }
    }
 }