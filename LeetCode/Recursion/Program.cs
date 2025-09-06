namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(5));
        }

        static int Factorial(int n)
        {
            if (n == 1) return 1;
            return Factorial(n - 1) * n;
        }


        //0, 1, 1, 2, 3, 5, 8, 13, 21
        static void FibonacciRecursion(int count, int iteration = 0, int n1 = 0, int n2 = 1)
        {
            Console.WriteLine(n1);
            if (count == iteration) return;
            FibonacciRecursion(count, ++iteration, n2, n1 + n2);
        }

        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        /*
         * 
         Fibonacci(5 - 1) + Fibonacci(5 - 2)
         Fibonacci(4 - 1) + Fibonacci(4 - 2)
         Fibonacci(3 - 1) + Fibonacci(3 - 2)
         Fibonacci(2 - 1) + Fibonacci(2 - 2) => 1 + Fibonacci(2 - 2)
         Fibonacci(2 - 1) + Fibonacci(5 - 2) => 1 + Fibonacci(5 - 2)
           
           
           
         */


        //static void Fibonacci(int count)
        //{
        //    int n1 = 0;
        //    int n2 = 1;
        //    int n3 = 0;
        //    while (count > 0)
        //    {
        //        n3 = n1 + n2;
        //        Console.WriteLine(n3);
        //        n1 = n2;
        //        n2 = n3;
        //        count--;
        //    }
        //}
    }
}

/*
Factorial(4) => Factorial(3) * 4
Factorial(3) => Factorial(2) * 3
Factorial(2) => Factorial(1) * 2
Factorial(1) => 1
 */