Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("Ура, Ваше число чётное");
}
else
{
    Console.Write("М-м. Ваше число нечётное");
}