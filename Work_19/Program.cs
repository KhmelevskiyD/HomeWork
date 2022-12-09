// Work 19

Console.Clear();
Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
while (number<10000 || number >100000)
{
    Console.WriteLine("Вы ошиблись. Введите пятизначное число");
    number = Convert.ToInt32(Console.ReadLine());
}
int n1 = number % 10;
int n2 = (number / 10) % 10;
int n3 = (number / 100) % 10;
int n4 = (number / 1000) % 10;
int n5 = (number / 10000) % 10;
// Console.WriteLine(n1);
// Console.WriteLine(n2);
// Console.WriteLine(n3);
// Console.WriteLine(n4);
// Console.WriteLine(n5);

int ntotal = n1*10000+n2*1000+n3*100+n4*10+n5;
// Console.WriteLine(ntotal); 
if (ntotal == number) Console.WriteLine($"Ваше число {number} является палиндромом");
else Console.WriteLine($"Ваше число {number} не является палиндромом");