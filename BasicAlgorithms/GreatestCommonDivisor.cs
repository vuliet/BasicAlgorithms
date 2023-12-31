﻿using Newtonsoft.Json;

namespace BasicAlgorithms
{
    public static class GreatestCommonDivisor
    {
        private static int GreatestCommonDivisorHandler(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private static int GreatestCommonDivisorHandler(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
                throw new ArgumentException("Danh sach so khong hop le");

            int result = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
                result = GreatestCommonDivisorHandler(result, numbers[i]);

            return result;
        }

        private static string ReplaceCharToEmpty(this string data, List<string> chars)
        {
            foreach (var item in chars)
                data = data.Replace(item, "");

            return data;
        }

        public static void GreatestCommonDivisorHandlerResult()
        {
            Console.WriteLine("Thuat toan Greatest Common Divisor:");

            List<int> numbers = new List<int> { 24, 36, 48 };

            try
            {
                int result = GreatestCommonDivisorHandler(numbers);

                var numbersConvertToString = JsonConvert.SerializeObject(numbers);

                numbersConvertToString = numbersConvertToString.ReplaceCharToEmpty(new List<string> { "[", "]" });

                Console.WriteLine($"Uoc so chung lon nhat cua: {numbersConvertToString} la {result}.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Loi: {ex.Message}");
            }
            finally
            {
                Console.WriteLine();
            }
        }
    }
}
