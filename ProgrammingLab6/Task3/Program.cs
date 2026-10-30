namespace Task3;

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите основную строку S: ");
        string S = Console.ReadLine() ?? "";
        Console.Write("Введите строку для поиска S1: ");
        string S1 = Console.ReadLine() ?? "";
        Console.Write("Введите строку для замены S2: ");
        string S2 = Console.ReadLine() ?? "";

        StringBuilder sb = new StringBuilder(S);
        
        int index = sb.ToString().IndexOf(S1);

        if (index != -1)
        {
            sb.Replace(S1, S2, index, S1.Length);
        }

        Console.WriteLine($"Результат: {sb.ToString()}");
    }
}
