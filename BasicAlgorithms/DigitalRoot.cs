namespace BasicAlgorithms
{
    // Tổng các chữ số của số đó ra số có 1 chữ số 
    // Ví dụ : 1876 = 1 + 8 + 7 + 6 = 22 = 2 + 2 = 4
    public class DigitalRoot
    {
        public static int DigitalRootHanlder(int n)
        {
            return n == 0 ? 0 : 1 + ((n - 1) % 9);
        }

        public static void DigitalRootResult()
        {
            int n = 1876;
            Console.WriteLine($"Thuat toan DigitalRoot:");
            var result = DigitalRootHanlder(n);

            Console.WriteLine($"DigitalRoot result {n} = {result}");
            Console.WriteLine();
        }
    }
}
