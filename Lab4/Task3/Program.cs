Random rnd = new Random();

int rows, cols;

Console.Write("Введите количество строк: ");
rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
cols = Convert.ToInt32(Console.ReadLine());

int even = 0;
int odd = 0;

double[,] arr = new double[rows, cols];
for(int i = 0; i < rows; i++)
{
    for(int j = 0; j < cols; j++)
    {
        arr[i, j] = rnd.Next(100);
        Console.Write($"{arr[i, j]}\t");
        if(arr[i, j] % 2 == 0)
        {
            even++;
        }
        else
        {
            odd++;
        }
    }
    Console.WriteLine();
}

Console.WriteLine($"Чётных - {even}; Нечётных - {odd}");