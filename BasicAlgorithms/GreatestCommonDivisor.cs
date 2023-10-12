using Newtonsoft.Json;

namespace BasicAlgorithms
{
    public class GreatestCommonDivisor
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
                throw new ArgumentException("Danh sách số không hợp lệ");

            int result = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
                result = GreatestCommonDivisorHandler(result, numbers[i]);

            return result;
        }

        public static void GreatestCommonDivisorHandlerResult()
        {
            Console.WriteLine("Thuat toan Greatest Common Divisor:");

            List<int> numbers = new List<int> { 24, 36, 48 };

            try
            {
                int result = GreatestCommonDivisorHandler(numbers);

                var numbersConvertToString = JsonConvert.SerializeObject(numbers).Replace("[", "").Replace("]", "");

                Console.WriteLine($"Uoc so chung lon nhat cua: {numbersConvertToString} là {result}.");
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
