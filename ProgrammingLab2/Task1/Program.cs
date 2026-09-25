int num;
do
{
    Console.Write("Введите двухзначное число: ");
    num = Convert.ToInt32(Console.ReadLine());
}
while(num >= 10 ^ num <= 99);
int digit1 = num % 10;
int digit2 = num / 10;
int sum = digit1 + digit2;

if(sum % 5 == 0)
{
    Console.WriteLine("Сумма цифр двухзначного числа кратна числу 5");
}
else
{
    Console.WriteLine("Сумма цифр двухзначного числа не кратна числу 5");
}