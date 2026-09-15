namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = 0;
            if(x > -3 && x <= -2)
            {
                y = 1 - (x + 3);
            }
            else if (x > -2 && x <= -1)
            {
                y = Math.Sqrt(1 - x * x);
            }
            else if (x > -1 & x <= 1)
            {
                y = 1;
            }
            else if (x > 1 & x <= 2)
            {
                y = 1 - (x - 1) * 2;
            }
            else if (x > 2 & x <= 5)
            {
                y = -1;
            }
            Console.WriteLine($"Y = {y}");
        }
    }
}
