﻿namespace BasicAlgorithms
{
    // Số nguyên tố : chỉ chia hết cho 1 và chính nó
    public static class IsPrime
    {
        public static void CheckNumberIsPrime()
        {
            Console.WriteLine("Check so nguyen to: ");
            var number = 100;

            bool isPrime = true;
            if (number < 2)
                isPrime = false;

            for (int i = 2; i < number / 2; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
                Console.WriteLine($"{number} la so nguyen to.");
            else
                Console.WriteLine($"{number} khong phai so nguyen to.");

            Console.WriteLine();
        }
    }
}
