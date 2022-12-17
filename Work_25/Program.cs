// Задача 25: Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.
// Не использовать Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Clear();
Console.WriteLine("Введите 1-е число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2-е число: ");
int m = int.Parse(Console.ReadLine()), sum = 1;
// int n = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < m; i++)
{
    sum *= n;
}
Console.WriteLine($"Натуральная степень первого числа равна {sum}");
