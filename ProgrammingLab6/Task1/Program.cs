namespace Task1;

using System;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите строку: ");
        string S = Console.ReadLine() ?? "";

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < S.Length; i++)
        {
            sb.Append(S[i]);
            if (i < S.Length - 1)
            {
                sb.Append(' ');
            }
        }

        Console.WriteLine($"Результат: {sb.ToString()}");
    }
}
