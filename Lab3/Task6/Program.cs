double m;

do 
{
    Console.WriteLine("Введите m: ");
    m = Convert.ToDouble(Console.ReadLine());
}
while(m == 0);

for (int i = 1; i <= 1000; i++)
{
    if (i % 5 == 0)
    {
        int hundreds = i / 100;
        int hundredsSquared = hundreds * hundreds;
        double result = hundredsSquared / m;

        if (hundreds > 0)
        {
            Console.WriteLine($"{i} | {hundreds} | {hundredsSquared} | {result}");
        }
    }
}