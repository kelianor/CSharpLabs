using System;
Random rnd = new Random();
int rows, cols;

Console.Write("Введите количество строк: ");
rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
cols = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[rows, cols];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        bool contains;
        do
        {
            contains = false;
            matrix[i, j] = rnd.Next(100);
            for(int m = 0; m <= i; m++)
            {
                for(int n = 0; n < ((m == i) ? j : cols); n++)
                {
                    if(matrix[m, n] == matrix[i, j])
                    {
                        contains = true;
                        break;
                    }
                }
            }
        } while(contains);
       
        
        
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine();
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();

double[] minInRows = new double[rows];
int[] minColsIndices = new int[rows];

for (int i = 0; i < rows; i++)
{
    double minVal = matrix[i, 0];
    int minCol = 0;

    for (int j = 1; j < cols; j++)
    {
        if (matrix[i, j] < minVal)
        {
            minVal = matrix[i, j];
            minCol = j;
        }
    }

    minInRows[i] = minVal;
    minColsIndices[i] = minCol;
}

double maxOfMins = minInRows[0];
int targetRow = 0;

for (int i = 1; i < rows; i++)
{
    if (minInRows[i] > maxOfMins)
    {
        maxOfMins = minInRows[i];
        targetRow = i;
    }
}

int targetCol = minColsIndices[targetRow];

Console.WriteLine($"Строка: {targetRow}, Колонка: {targetCol}");
