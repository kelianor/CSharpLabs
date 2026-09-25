int[] daysInMonth = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
string[] monthName = {"Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"};

Console.Write("Введите количество прошедших месяцев: ");
int monthElapsed = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество прошедших дней: ");
int daysElapsed = Convert.ToInt32(Console.ReadLine());

int month;
for(month = monthElapsed % 12; daysElapsed >= daysInMonth[month]; month = (month + 1) % 12)
{
    daysElapsed -= daysInMonth[month];
}

Console.WriteLine(monthName[month]);
