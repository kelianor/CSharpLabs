namespace Task2;

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите строку: ");
        string S = Console.ReadLine() ?? "";

        if (string.IsNullOrEmpty(S)) return;

        int result = S[0] - '0'; 

        for (int i = 1; i < S.Length; i += 2)
        {
            char op = S[i];
            int nextDigit = S[i + 1] - '0';

            if (op == '+')
            {
                result += nextDigit;
            }
            else if (op == '-')
            {
                result -= nextDigit;
            }
        }

        Console.WriteLine($"Результат: {result}");
    }
}
