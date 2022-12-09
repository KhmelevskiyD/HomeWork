// Work 21

Console.Clear();
Console.Write("Введите координату x 1-ой точки: ");
double x_1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y 1-ой точки: ");
double y_1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z 1-ой точки: ");
double z_1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y 2-ой точки: ");
double x_2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату x 2-ой точки: ");
double y_2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z 2-ой точки: ");
double z_2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Math.Round(
    Math.Sqrt(Math.Pow(x_1 - x_2, 2) + Math.Pow(y_1 - y_2, 2) + Math.Pow(z_1 - z_2, 2)), 2));

// Math.Round(i, 2); - Округление до двух знаков
// Math.Sqrt(i, 2); - Возвращает значение double из квадратного корня
// Math.Pow(i, 2); - Возвращает значение double возведенное в степень