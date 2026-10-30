namespace Task2;

using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string pattern = @"\d+(?:[.,]\d+)?";
        bool cont;

        do
        {
            Console.Write("Введите целые и вещественные числа: ");
            string numbers = Console.ReadLine() ?? "";

            Regex reg = new Regex(pattern);
            MatchCollection matches = reg.Matches(numbers);
            
            foreach (Match m in matches)
            {
                Console.WriteLine(m.Value);
            }

            Console.Write("Желаете продолжить? True - Да, False - Нет: ");
            cont = Convert.ToBoolean(Console.ReadLine());
        }
        while (cont);
    }
}
