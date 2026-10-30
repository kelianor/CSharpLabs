namespace Task1;

using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string pattern = @"^((\d{4} ){3}\d{4})$";
        bool cont;

        do
        {
            Console.Write("Введите номер кредитки: ");
            string creditCardNumber = Console.ReadLine() ?? "";

            if (Regex.IsMatch(creditCardNumber, pattern))
            {
                Console.WriteLine($"{creditCardNumber} - это валидный номер кредитки!");
            }
            else
            {
                Console.WriteLine($"{creditCardNumber} - не валидный номер кредитки!");
            }

            Console.Write("Желаете продолжить? True - Да, False - Нет: ");
            cont = Convert.ToBoolean(Console.ReadLine());
        }
        while(cont);
    }
}
