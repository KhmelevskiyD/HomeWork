// Площадь треугольника.
// По целочисленным координатам вершин треугольника 
// (x1,y1), (x2,y2) и (x3,y3) требуется вычислить его площадь.

// Решене преподователя

Console.Clear();
Console.WriteLine("Введите координаты 3-х вершин треугольника");
double[] coord = Console.ReadLine().Split(" ").Select(x => Convert.ToDouble(x)).ToArray();
double x1 = coord[0], y1 = coord[1], x2 = coord[2], y2 = coord[3], x3 = coord[4], y3 = coord[5];
double AB = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
double BC = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
double AC = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
double p = (AB + BC + AC) / 2;
double S = Math.Sqrt(p * (p - AB) * (p - BC) * (p - AC));
Console.WriteLine(Math.Round(S, 2));
