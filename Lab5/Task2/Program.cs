using System.Runtime.InteropServices.Marshalling;

namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();

        const int SIZE = 12;
        Array arr = Array.CreateInstance(typeof(int), SIZE);
        
        for(int i = 0; i < SIZE; i++)
        {
            arr.SetValue(rnd.Next(-50, 50), i);
        }

        Console.WriteLine("Заполненный массив:");
        foreach(int num in arr)
        {
            Console.Write($"{num, 6}");
        }

        Array negEvenArr = Array.FindAll((int[])arr, x => x < 0 && x % 2 == 0);
        Console.WriteLine("\n\nМассив четных отрицательных чисел:");

        bool hasPos = false;
        foreach(int num in negEvenArr)
        {
            Console.Write($"{num, 6}");
            if(num > 0)
            {
                hasPos = true;
            }
        }
        Console.WriteLine(hasPos ? "\nМассив имеет положительные числа" : "\nМассив не имеет положительных чисел");

        Console.WriteLine("\nРазвернуть (Reverse) элементы с 5 по 9 индексы: ");
        Array.Reverse(arr, 5, 9 - 5);

        foreach(int num in arr)
        {
            Console.Write($"{num, 6}");
        }

        Console.WriteLine("\n\nОтсортировать (Sort) элементы с 3 по 7 индексы: ");
        Array.Sort(arr, 3, 7 - 3);

        foreach(int num in arr)
        {
            Console.Write($"{num, 6}");
        }
        Console.WriteLine();
    }
}
