namespace Task3;

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
                double y = 0;
                f(x, out y);
                Console.WriteLine($"{x,8}|{y,8}");
            }

            Console.Write("Желаете продолжить? True - Да, False - Нет: ");
            cont = Convert.ToBoolean(Console.ReadLine());
        }
        while (cont);
    }

    static double f(double x)
    {
        if (x <= 5)
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

    static void f(double x, out double y)
    {
        if (x <= 5)
        {
            y = x * x + 5;
        }
        else if (x > 5 && x < 20)
        {
            y = 0;
        }
        else
        {
            y = 1;
        }
    }
}
