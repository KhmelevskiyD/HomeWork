// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3, 7, 22, 2, 78] -> 76

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(1, 101); // [1, 100]
// }

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
// Console.Clear();
// int n = new Random().Next(5, 11);
// int[] array = new int[n]; // {0, 0,....}
// InputArray(array);
// Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
// Console.WriteLine($"Разница между Max и Min элемнтом массива составляет {ReleaseArray(array)}");


// Решение от преподователя
void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble() * (10 + 10) - 10, 2); // [-10, 10]
}

double MinArray(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
    }
    return min;
}

double MaxArray(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
    }
    return max;
}

Console.Clear();
Console.Write("Введите кол-во чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine(MaxArray(array) - MinArray(array));