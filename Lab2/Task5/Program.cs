namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            bool collides = false;
            if(x > 0 & y > 0)
            {
                collides = x * x + y * y < r * r;
            }
            else if (x < 0 & y < 0)
            {
                collides = y > r - x;
            }
            Console.WriteLine($"Collision: {collides}");
        }
    }
}
