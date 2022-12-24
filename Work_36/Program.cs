// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 101); // [-100, 100]
}

int SumArray(int[] array)
{   
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 > 0)
            sum += array[i];
    }       
    return sum;
}

Console.Clear();
int n = new Random().Next(5, 11);
int[] array = new int[n]; // {0, 0,....}
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine(SumArray(array));


// Решене от преподователя
// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-10, 11); // [-10, 10]
// }

// int SummaOdd(int[] array)
// {
//     int sum = 0;
//     for (int i = 1; i < array.Length; i+=2)
//         sum += array[i];
//     return sum;
// }

// Console.Clear();
// Console.Write("Введите кол-во чисел: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine(string.Join(" ", array));
// Console.WriteLine(SummaOdd(array));