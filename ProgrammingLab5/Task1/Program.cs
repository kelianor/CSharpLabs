namespace Task1;

using System;

class Program
{
    static void Main(string[] args)
    {
        bool cont;

        do
        {
            Console.Write("Введите число: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Результат:  {f(num)}");

            Console.Write("Желаете продолжить? True - Да, False - Нет: ");
            cont = Convert.ToBoolean(Console.ReadLine());
        }
        while (cont);
    }

    static double f(double x)
    {
        if (x % 5 == 0)
        {
            return x / 5;
        }
        return x + 1;
    }
}