namespace Task4;

class Program
{
    static void Main(string[] args)
    {
        bool cont;

        do
        {
            Console.Write("Введите n: ");
            long n = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine($"Результат:  {GetElement(n)}");

            Console.Write("Желаете продолжить? True - Да, False - Нет: ");
            cont = Convert.ToBoolean(Console.ReadLine());
        }
        while (cont);
    }
    static long GetElement(long n)
    {
        if (n == 1) return -10;
        if (n == 2) return 2;

        return Math.Abs(GetElement(n - 2)) - 6 * GetElement(n - 1);
    }
}
