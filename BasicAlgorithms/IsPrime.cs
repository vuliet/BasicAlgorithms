namespace BasicAlgorithms
{
    // Số nguyên tố : chỉ chia hết cho 1 và chính nó
    public static class IsPrime
    {
        public static void CheckNumberIsPrime()
        {
            Console.WriteLine("Check so nguyen to: ");
            var number = 3;

            bool isPrime = true;

            if (number < 2)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            Console.WriteLine($"{number} {(isPrime ? "la so nguyen to." : "khong phai so nguyen to.")}");
            Console.WriteLine();
        }
    }
}
