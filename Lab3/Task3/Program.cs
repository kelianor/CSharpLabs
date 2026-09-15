double x_begin, x_end, delta_x, error_bar;

do
{
    Console.WriteLine("Введите X-нач: ");
    x_begin = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите X-кон: ");
    x_end = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите шаг: ");
    delta_x = Convert.ToDouble(Console.ReadLine()); 

    Console.WriteLine("Введите погрешность: ");
    error_bar = Convert.ToDouble(Console.ReadLine()); 
}
while(Math.Abs(x_begin) <= 1 | Math.Abs(x_end) <= 1);

Console.WriteLine("\tx\t|\tf(x)\t|\tn");
for(double x = x_begin; x <= x_end; x += delta_x)
{
    double n = 0.0, sum = 0.0;

    double powerTerm = 1.0 / x; 
    double xSquaredInv = 1.0 / (x * x);
    
    double currentTerm;

    do
    {
        currentTerm = powerTerm / (2 * n + 1);
        sum += currentTerm;
        powerTerm *= xSquaredInv;
        n++;
    }
    while(Math.Abs(currentTerm) >= error_bar);

    Console.WriteLine($"\t{x}\t|\tf({sum})\t|\t{n}");
}