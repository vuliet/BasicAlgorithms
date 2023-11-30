namespace BasicAlgorithms
{
    public class Fibonacci
    {
        public static int FibonacciHandler(int n)
        {
            if (n <= 1)
                return n;
            return FibonacciHandler(n - 1) + FibonacciHandler(n - 2);
        }

        public static void FibonacciResult()
        {
            int n = 3;
            Console.WriteLine($"Thuat toan Fibonacci:");
            var result = FibonacciHandler(n);

            Console.WriteLine($"Fibonacci result {n} = {result}");
            Console.WriteLine();
        }
    }
}
