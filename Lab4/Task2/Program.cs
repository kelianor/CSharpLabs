const int SIZE = 9;

int[] arr = new int[SIZE];

for(int i = 0; i < SIZE; i++)
{
    do
    {
        Console.Write($"arr[{i}] = ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    while(arr[i] > 9 ^ arr[i] < 100);
}

int[] sumArr = new int[SIZE];

for(int i = 0; i < SIZE; i++)
{
    sumArr[i] = arr[i] % 10 + arr[i] / 10;
    Console.WriteLine($"sumArr[{i}] =  {sumArr[i]}");
}
