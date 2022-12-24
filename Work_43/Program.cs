// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void point (double[] point)
{
double x = (point[2]-point[0])/(point[1]-point[3]);
double y = point[1]*x+point[0];
Console.WriteLine($"точка пересечения двух прямых равняется ({x};{y}) ");
}

Console.Clear();
Console.WriteLine("Введите координаты прямых поочереди, через пробел: ");
double[] lines = Console.ReadLine().Split(" ").Select(x => double.Parse(x)).ToArray();
point(lines);

