Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите цифру X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите цифру Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int i = a;
while (i <= b)
{
    int lastDigit = Math.Abs(i) % 10; 
    
    if (lastDigit == x | lastDigit == y)
    {
        Console.WriteLine(i);
    }

    i++;
}