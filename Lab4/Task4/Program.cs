Random rnd = new Random();

int rows, cols;

Console.Write("Введите количество строк: ");
rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
cols = Convert.ToInt32(Console.ReadLine());

double[,] arr = new double[rows, cols];
for(int i = 0; i < rows; i++)
{
    for(int j = 0; j < cols; j++)
    {
        arr[i, j] = rnd.Next(10);
        Console.Write($"{arr[i, j]}\t");
    }
    Console.WriteLine();
}

Console.Write("Введите число: ");

double num = Convert.ToDouble(Console.ReadLine());
int count = 0;

for(int i = 0; i < rows; i++)
{
    for(int j = 0; j < cols; j++)
    {
        if(arr[i, j] == num)
        {
            count++;
        }
    }
}

Console.WriteLine($"Количество элементов равных {num} - {count}");