double x_begin = -Math.PI / 2.0, x_end = Math.PI, delta_x = 0.2;

Console.WriteLine("\tx\t|\tf(x)\t");
for(double x = x_begin; x <= x_end; x += delta_x)
{
    double y = 0;
    if(x > 2)
    {
        y = Math.Sqrt(Math.Log(x * x - 1));
    }
    else if (x >= 0 && x <= 2)
    {
        y = -2 * Math.Pow(x, 3);
    }
    else if (x < 0)
    {
        y = Math.Exp(Math.Sin(x));
    }
    else
    {
        y = 0;
    }
    Console.WriteLine($"\t{x}\t|\tf({y})\t");
}