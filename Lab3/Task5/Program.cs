double x;
do
{
    Console.Write("Введите x: ");
    x = Convert.ToDouble(Console.ReadLine());
}
while(x == 0);

int n;
do
{
    Console.Write("Введите n: ");
    n = Convert.ToInt32(Console.ReadLine());
}
while (n < 1);

double totalSum = 0.0;
for (int k = 1; k <= n; k++)
{
    if (k == 5)
    {
        Console.WriteLine($"Шаг k = 5 пропущен");
        continue;
    }
    if (x == 0 && k > 0)
    {
        Console.WriteLine("Деление на ноль!");
        return;
    }

    double sign = ((3 * k + 1) % 2 == 0) ? 1.0 : -1.0;

    double product = 1.0;
    bool skipTerm = false;
    int upperM = k + 7;

    for (int m = 4; m <= upperM; m++)
    {
        product *= (double)(m * m - 9) / (m - 2);
    }

    if (skipTerm) continue;
    double denominator = (k - 5) * Math.Pow(x, k);
    totalSum += (sign / denominator) * product;
}
Console.WriteLine($"S = {totalSum}");
