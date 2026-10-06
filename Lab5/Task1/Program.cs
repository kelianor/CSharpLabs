namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();

        Console.Write("Введите размер массива: ");
        int arraySize = Convert.ToInt32(Console.ReadLine());

        double[] arr = new double[arraySize];

        int absMinIndex = 0;
        double absMin = double.MaxValue;

        double sumAfterNegative = 0;
        bool isNegativeFound = false;

        for (int i = 0; i < arraySize; i++)
        {
            arr[i] = Math.Round(rnd.NextDouble() * 200 - 100, 2);

            if (isNegativeFound)
            {
                sumAfterNegative += Math.Abs(arr[i]);
            }

            if (Math.Abs(arr[i]) < absMin)
            {
                absMinIndex = i;
                absMin = Math.Abs(arr[i]);
            }

            if (arr[i] < 0)
            {
                isNegativeFound = true;
            }
        }

        Console.WriteLine("\nМассив до преобразований:");
        foreach (double num in arr)
        {
            Console.Write($"{num,8}");
        }
        Console.WriteLine();

        Console.Write("\nВведите a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        if (b < a)
        {
            double tmp = a;
            a = b;
            b = tmp;
        }

        Console.WriteLine($"\nИндекс минимального по модулю элемента массива: {absMinIndex}");
        
        Console.WriteLine($"Сумма модулей элементов после первого отрицательного: {sumAfterNegative:F2}");

        int writeIndex = 0;
        for (int readIndex = 0; readIndex < arraySize; readIndex++)
        {
            if (arr[readIndex] < a || arr[readIndex] > b)
            {
                arr[writeIndex] = arr[readIndex];
                writeIndex++;
            }
        }

        for (; writeIndex < arraySize; writeIndex++)
        {
            arr[writeIndex] = 0;
        }

        Console.WriteLine("\nПреобразованный массив:");
        foreach (double num in arr)
        {
            Console.Write($"{num,8}");
        }
        Console.WriteLine();
    }
}
