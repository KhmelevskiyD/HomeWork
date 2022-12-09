Console.Clear();
Console.WriteLine("Введите кол-во кустов черники: ");
int bushes = Convert.ToInt32(Console.ReadLine());

int[] berry = new int[bushes];
for (int i = 0; i < berry.Length; i++)
{
    Console.Write($"Введите количество ягод на {i + 1} кусте: ");
    berry[i] = Convert.ToInt32(Console.ReadLine());
}
int maxberry = 0;
for (int i = 1; i < berry.Length-1; i++)
{
if (berry[i-1]+berry[i]+berry[i+1] > maxberry)
    maxberry = berry[i-1]+berry[i]+berry[i+1];
}
Console.WriteLine($"Модуль собереет максимально {maxberry} ягод(ы)");