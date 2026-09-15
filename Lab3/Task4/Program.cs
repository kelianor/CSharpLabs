do
{
    Console.Write("Введите N: ");
    int n = Convert.ToInt32(Console.ReadLine());
}
while (n < 0);

double product = 2.0;

for (int i = 2; i <= n; i++)
{
    product *= 1.0 / i;
}

Console.WriteLine($"Результат произведения: {product}");