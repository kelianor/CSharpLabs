namespace Task5;

class Program
{
    static void Main(string[] args)
    {
        bool cont;

        do
        {
            Console.Write("Введите натуральное число: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Все делители натурального числа: ");
            PrintDivisors(n, 1);

            Console.Write("Желаете продолжить? True - Да, False - Нет: ");
            cont = Convert.ToBoolean(Console.ReadLine());
        }
        while (cont);
    }

    static void PrintDivisors(int n, int current)
    {
        if (current > n)
        {
            return;
        }

        if (n % current == 0)
        {
            Console.WriteLine($"{current} * {n / current} = {n}");
        }

        PrintDivisors(n, current + 1);
    }
}
