namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        bool cont;

        do
        {
            Console.Write("Введите a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите h: ");
            double h = Convert.ToDouble(Console.ReadLine());

            for (double x = a; x <= b; x += h)
            {
                Console.WriteLine($"{x,8}|{f(x),8}");
            }

            Console.Write("Желаете продолжить? True - Да, False - Нет: ");
            cont = Convert.ToBoolean(Console.ReadLine());
        }
        while (cont);
    }

    static double f(double x)
    {
        if(x <= 5)
        {
            return x * x + 5;
        }
        else if (x > 5 && x < 20)
        {
            return 0;
        }
        else
        {
            return 1;
        }
    }
}
