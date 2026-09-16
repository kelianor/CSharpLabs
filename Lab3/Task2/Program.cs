Console.Write("R = ");
double r = Convert.ToDouble(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Введите координаты для {i}-го  выстрела:");
    
    Console.Write("X = ");
    double x = Convert.ToDouble(Console.ReadLine());
    
    Console.Write("Y = ");
    double y = Convert.ToDouble(Console.ReadLine());

    bool collides = false;
    if(x > 0 & y > 0)
    {
        collides = x * x + y * y < r * r;
    }
    else if (x < 0 & y < 0)
    {
        collides = y > r - x;
    }
    
    if(collides)
    {
        Console.WriteLine("Есть попадание!");
    }
    else
    {
        Console.WriteLine("Промах :(");
    }
}