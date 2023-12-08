namespace BasicAlgorithms
{
    public static class DataStructure
    {
        public static bool IsStringValid(string input)
        {
            Stack<char> stack = new();

            foreach (char character in input)
            {
                if (character == '(' || character == '{')
                {
                    stack.Push(character);
                }
                else if (character == ')' && (stack.Count == 0 || stack.Pop() != '('))
                {
                    return false;
                }
                else if (character == '}' && (stack.Count == 0 || stack.Pop() != '{'))
                {
                    return false;
                }
            }

            return stack.Count == 0;
        }

        public static void IsStringValidResult()
        {
            Console.WriteLine("Kiem tra chuoi co hop le co the dong va mo:");

            var input1 = "{()()}";
            var input2 = "{})";
            var input3 = "{}{}";
            var input4 = "{(())}";
            var input5 = "{(})";
            var input6 = "{";
            var input7 = "{)";
            var input = input4;

            var isValid = IsStringValid(input);

            var text = isValid ? "hop le" : "khong hop le";

            Console.WriteLine($"chuoi input {input} : {text}");

            Console.WriteLine();
        }
    }
}
