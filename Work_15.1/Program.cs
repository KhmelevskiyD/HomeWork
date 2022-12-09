Console.Clear();
Console.WriteLine("Введите любые числа. По окончании введите ноль");
int number = Convert.ToInt32(Console.ReadLine());
int Max1 = 0;
int Max2 = 0;
while (number != 0)
{
    if (number > Max1) 
    {
        Max2 = Max1;
        Max1 = number;
    }
    else  if (number > Max2) Max2 = number;
number = Convert.ToInt32(Console.ReadLine());
}
// Console.WriteLine(Max1);
Console.WriteLine($"Второй максимум равен: {Max2}");
