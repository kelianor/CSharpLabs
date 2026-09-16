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
        Console.Write($"arr[{i}, {j}] = ");
        arr[i, j] = Convert.ToDouble(Console.ReadLine());
    }
}


double maxOfMin = 0;
int targetRow = -1;
int targetCol = -1;

for (int i = 0; i < rows; i++)
{
    double minInRow = arr[i, 0];
    int minColIdx = 0;

    for (int j = 1; j < cols; j++)
    {
        if (arr[i, j] < minInRow)
        {
            minInRow = arr[i, j];
            minColIdx = j;
        }
    }

    if (i == 0 | minInRow > maxOfMin)
    {
        maxOfMin = minInRow;
        targetRow = i;
        targetCol = minColIdx;
    }
}

Console.WriteLine($"Максимальный среди минимальных элемент: {maxOfMin}");
Console.WriteLine($"Индексы элемента: строка [{targetRow}], столбец [{targetCol}]");