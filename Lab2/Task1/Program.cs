namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            do
            {
                Console.WriteLine("Введите трёхзначное число: ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            while (num <= 999 ^ num >= 100);

            int digit1 = num % 10;
            int digit2 = (num / 10) % 10;
            int digit3 = (num / 100) % 10;

            if (digit1 == digit2 && digit2 == digit3)
            {
                Console.WriteLine("Все цифры числа равны");
            }

            if (digit1 == digit2 | digit2 == digit3 | digit1 == digit3)
            {
                Console.WriteLine("В числе есть одинаковые цифры");
            }
        }
    }
}
