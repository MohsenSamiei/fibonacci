using System;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci(30); //warmup
            for (int i = 10; i < 50; i+=5)
            {
                var start = DateTime.Now;
                Fibonacci(i);
                var duration = DateTime.Now - start;
                Console.WriteLine($"{i} => {(int)(duration).TotalMilliseconds}");
            }
        }

        static int Fibonacci(int number)
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
}
