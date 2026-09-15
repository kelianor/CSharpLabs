namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            if (a / Math.Abs(a) == b / Math.Abs(b))
            {
                a = b = 0;
            }
            else
            {
                a *= -1;
                b *= -1;
            }

            Console.WriteLine($"A = {a}");
            Console.WriteLine($"B = {b}");
        }
    }
}
