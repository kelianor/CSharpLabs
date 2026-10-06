double x_begin, x_end, delta_x;

Console.WriteLine("Введите X-нач: ");
x_begin = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите X-кон: ");
x_end = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите шаг: ");
delta_x = Convert.ToDouble(Console.ReadLine()); 

Console.WriteLine("\tx\t|\tf(x)\t");
for(double x = x_begin; x <= x_end; x += delta_x)
{
    double y = 0;
    if(x >= -3 && x <= -2)
    {
        y = 1 - (x + 3);
    }
    else if (x > -2 && x <= -1)
    {
        y = Math.Sqrt(1 - (x + 1) * (x + 1));
    }
    else if (x > -1 & x <= 1)
    {
        y = 1;
    }
    else if (x > 1 & x <= 2)
    {
        y = 1 - (x - 1) * 2;
    }
    else if (x > 2 & x <= 5)
    {
        y = -1;
    }
    Console.WriteLine($"\t{x}\t|\t{y}\t");
}