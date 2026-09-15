Console.WriteLine("Вводите числа по одному (для окончания ввода введите 0):");
int sum = 0;

while (true)
{
    int number = Convert.ToInt32(Console.ReadLine());

    
    if (number == 0)
    {
        break;
    }

    if (number < 0)
    {
        sum += number;
    }
}

Console.WriteLine($"Сумма: {sum}");