double a, b, alpha;
Console.Write("Введите a: ");
a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b: ");
b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите alpha: ");
alpha = Convert.ToDouble(Console.ReadLine());
double s = a*b*Math.Sin(alpha)/2.0;
Console.WriteLine($"S = {s}");