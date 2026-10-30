namespace Task4;

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите строку: ");
        string S = Console.ReadLine() ?? "";

        string[] arr = S.Split(" ");
        Array.Sort(arr);

        string S1 = String.Join(" ", arr);

        Console.WriteLine($"Результат: {S1}");
    }
}
