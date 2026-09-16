const int SIZE = 14;

int[] arr = new int[SIZE];
int sum = 0, count = 0;

for(int i = 0; i < SIZE; i++)
{
    Console.Write($"arr[{i}] = ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
    if(arr[i] >= 0 & arr[i] % 2 == 0)
    {
        count++;
        sum += arr[i];
    }
}

Console.WriteLine($"Количество - {count}; Сумма - {sum}");