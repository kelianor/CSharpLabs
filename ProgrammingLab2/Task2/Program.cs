Console.Write("x = ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("y = ");
double y = Convert.ToDouble(Console.ReadLine());

Console.Write("Лежит ли точка внутри заштрихованной области: ");
if (Math.Abs(x) == 50 & Math.Abs(y) <= 25 | Math.Abs(y) == 25 & Math.Abs(x) <= 50)
{
    Console.WriteLine("На границе");
}
else if (Math.Abs(x) < 50 & Math.Abs(y) < 25)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}