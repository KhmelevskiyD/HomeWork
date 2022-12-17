// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

//1 способ
Console.Clear();
Console.WriteLine("Введите число: ");
string number = Convert.ToString(Console.ReadLine());
int count = number.Length;
int newNumber = 0;
for (int i = 0; i < count; i++)
{
    newNumber = newNumber + int.Parse(number[i].ToString());
}
Console.WriteLine(newNumber);


//2 способ
Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()), sumNumber = 0;
while (number > 0)
{
    sumNumber = sumNumber + number % 10;
    number /= 10;
}
Console.WriteLine(sumNumber);