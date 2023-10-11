namespace BasicAlgorithms
{
    // Một số hoàn hảo : một số nguyên dương mà tổng của tất cả các ước số dương của nó (ngoại trừ chính nó) bằng chính nó.
    public static class IsPerfect
    {
        public static void CheckIsPerfectNumber()
        {
            Console.WriteLine("Check so hoan hao: ");

            int number = 28;

            int sum = 0;

            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                    sum += i;
            }

            bool isPerfect = sum == number;

            if (isPerfect)
                Console.WriteLine($"{number} la so hoan hao.");
            else
                Console.WriteLine($"{number} khong phai la so hoan hao.");

            Console.WriteLine();
        }
    }
}
