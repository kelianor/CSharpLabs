namespace Task2;

using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string pattern = @"(?<major>\d+)\.(?<minor>\d+)\.(?<patch>\d+)(?:-(?<prefix>[0-9A-Za-z-]+))?";
        bool cont;

        do
        {
            Console.Write("Введите текст, содержащий семантические версии: ");
            string numbers = Console.ReadLine() ?? "";

            Regex reg = new Regex(pattern);
            MatchCollection matches = reg.Matches(numbers);
            
            foreach (Match m in matches)
            {
                GroupCollection versioning = m.Groups;
                Console.WriteLine($"Match {m.Index}:");
                Console.WriteLine($"Major - {versioning["major"].Value}");
                Console.WriteLine($"Minor - {versioning["minor"].Value}");
                Console.WriteLine($"Patch - {versioning["patch"].Value}");
                Console.WriteLine($"Prefix - {versioning["prefix"].Value}");
                Console.WriteLine();
            }

            Console.Write("Желаете продолжить? True - Да, False - Нет: ");
            cont = Convert.ToBoolean(Console.ReadLine());
        }
        while (cont);
    }
}
