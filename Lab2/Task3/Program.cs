namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите код города: ");
            int city = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длительность разговора: ");
            double duration = Convert.ToDouble(Console.ReadLine());

            double price = 0;

            switch (city)
            {
                case 048:
                    price = 15;
                    break;
                case 044:
                    price = 18;
                    break;
                case 046:
                    price = 13;
                    break;
                case 045:
                    price = 11;
                    break;
            }
            Console.WriteLine($"Стоимость - {price * duration}");
        }
    }
}
