namespace ITK
{
    internal class ITK
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Введите x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y: ");
            y = Convert.ToDouble(Console.ReadLine());

            bool collision = (y < -3 & y > -4) || y > 1;
            Console.WriteLine($"Ans: {collision}");
        }
    }
}
