﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.WriteLine("Введите числа через пробел: ");
int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
 
int count = 0;
foreach (int element in numbers)
{
    if (element > 0)
    {
        count++;
    }
}
Console.Write($"Введено {count} значений больше 0");