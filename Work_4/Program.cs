Console.Clear();
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int Max = num1;

if (num2 > num1) Max = num2;
if (num3 > Max) Max = num3;

Console.WriteLine($"max: {Max}");