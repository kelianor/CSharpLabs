Console.Write("Введите количество секунд");
int seconds = Convert.ToInt32(Console.ReadLine());
int minutes = seconds / 60;
int hours = minutes / 60;
Console.WriteLine($"Часов: {hours}");