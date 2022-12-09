Console.Clear();
Console.WriteLine("Введите трёхзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
int n1 = number / 10;
int n2 = n1 % 10;
Console.WriteLine(n2);