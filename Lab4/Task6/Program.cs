using System;

namespace Task6;
class Matrix
{
    private int rows;
    private int cols;
    private double[,] arr;
    public Matrix(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;
        arr = new double[rows, cols];
    }
    public void fill()
    {
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                arr[i, j] = Convert.ToDouble(Console.ReadLine());
                Console.SetCursorPosition((j+1) * 8, Console.CursorTop - 1);
            }
            Console.WriteLine();
        }
    }
    public void triangulate()
    {
        int minDim = Math.Min(rows, cols);
        for (int k = 0; k < minDim; k++)
        {
            int maxRow = k;
            for (int i = k + 1; i < rows; i++)
            {
                if (Math.Abs(arr[i, k]) > Math.Abs(arr[maxRow, k]))
                {
                    maxRow = i;
                }
            }
            if (Math.Abs(arr[maxRow, k]) < 1e-9)
                continue;
            if (maxRow != k)
            {
                swapRows(k, maxRow);
            }
            for (int i = k + 1; i < rows; i++)
            {
                double factor = arr[i, k] / arr[k, k];
                for (int j = k; j < cols; j++)
                {
                    arr[i, j] -= factor * arr[k, j];
                }
            }
        }
    }
    public void swapCols(int from, int to)
    {
        for (int i = 0; i < rows; i++) 
        {
            double tmp = arr[i, from];
            arr[i, from] = arr[i, to];
            arr[i, to] = tmp;
        }
    }

    public void swapRows(int from, int to)
    {
        for (int i = 0; i < cols; i++) 
        {
            double tmp = arr[from, i];
            arr[from, i] = arr[to, i];
            arr[to, i] = tmp;
        }
    }
    public void print()
    {
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                Console.Write(arr[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    public int GetCountRowsLessAverage(double limit)
    {
        int count = 0;
        for (int i = 0; i < rows; i++)
        {
            double sum = 0;
            for (int j = 0; j < cols; j++)
            {
                sum += arr[i, j];
            }
            double avg = sum / cols;
            if (avg < limit)
            {
                count++;
            }
        }
        return count;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество строк: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите количество столбцов: ");
        int cols = Convert.ToInt32(Console.ReadLine());

        Matrix m = new Matrix(rows, cols);
        m.fill();

        Console.Write("Введите заданную величину: ");
        double val = Convert.ToDouble(Console.ReadLine());
        
        int res = m.GetCountRowsLessAverage(val);
        Console.WriteLine("Количество строк до триангуляции: " + res);

        m.triangulate();
        Console.WriteLine("Результат триангуляции:");
        m.print();
    }
}
