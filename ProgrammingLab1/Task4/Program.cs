Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Введите число C: ");
int c = int.Parse(Console.ReadLine());

Console.WriteLine((a + b == 0) || (b + c == 0) || (a + c == 0) ? "Истина" : "Ложь");