﻿// Вася не любит английский язык, но каждый раз старается получить хотя бы четверку за четверть, 
// чтобы оставаться ударником. В текущей четверти Вася заметил следующую закономерность: 
// по нечетным дням месяца он получал тройки, а по четным – четверки. Так же он помнит, 
// в какие дни он получал эти оценки. Поэтому он выписал на бумажке все эти дни для того, 
// чтобы оценить, сколько у него троек и сколько четверок. Помогите Васе это сделать, 
// расположив четные и нечетные числа в разных строчках. Вася может рассчитывать на оценку 4, 
// если четверок не меньше, чем троек.
// **Входные данные: В первой строке записано единственное число N – количество элементов 
// целочисленного массива (1 ≤ N ≤ 100). Вторая строка содержит N чисел, представляющих заданный 
// массив. Каждый элемент массива – натуральное число от 1 до 31. Все элементы массива разделены 
// пробелом.
// **Выходные данные: В первую строку нужно вывести числа, которые соответствуют дням месяцев,
//  в которые Вася получил тройки, а во второй строке соответственно расположить числа месяца, 
//  в которые Вася получил четверки. В третьей строке нужно вывести «YES», если Вася может 
//  рассчитывать на четверку и «NO» в противном случае. В каждой строчке числа следует выводить 
// в том же порядке, в котором они идут во входных данных. При выводе числа отделяются пробелом.

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 32); // [1, 31]
}

void OutputArray(int[] array)
{
    int[] chetarray = new int[n];
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
        chetarray [i] = 

}

// int ReleaseArray(int[] array)
// {
//     int MaxNumber = 0;
//     int MinNumber = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > MaxNumber)
//             MaxNumber = array[i];
//         else if (array[i] <= MinNumber)
//             MinNumber = array[i];
//     }
//     int sum = MaxNumber - MinNumber;
//     return sum;
// }
Console.Clear();
Console.WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
// Console.WriteLine($"Разница между Max и Min элемнтом массива составляет {ReleaseArray(array)}");