Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 2;

while (i <= num)
{
    Console.Write($"{i} ");
    i = i + 2;
}
