int[] daysInMonth = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
Console.Write("Введите количество прошедших месяцев: ");
int monthElapsed = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество прошедших дней: ");
int daysElapsed = Convert.ToInt32(Console.ReadLine());

int month;
for(month = monthElapsed % 12; daysElapsed >= daysInMonth[month]; month = (month + 1) % 12)
{
    daysElapsed -= daysInMonth[month];
}

switch(month+1)
{
    case 1:
    Console.WriteLine("Январь");
    break;
    case 2:
    Console.WriteLine("Февраль");
    break;
    case 3:
    Console.WriteLine("Март");
    break;
    case 4:
    Console.WriteLine("Апрель");
    break;
    case 5:
    Console.WriteLine("Май");
    break;
    case 6:
    Console.WriteLine("Июнь");
    break;
    case 7:
    Console.WriteLine("Июль");
    break;
    case 8:
    Console.WriteLine("Август");
    break;
    case 9:
    Console.WriteLine("Сентябрь");
    break;
    case 10:
    Console.WriteLine("Октябрь");
    break;
    case 11:
    Console.WriteLine("Ноябрь");
    break;
    case 12:
    Console.WriteLine("Декабрь");
    break;
}
