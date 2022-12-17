// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3, 7, 22, 2, 78] -> 76

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 101); // [1, 100]
}

int ReleaseArray(int[] array)
{
    int MaxNumber = 0;
    int MinNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > MaxNumber)
            MaxNumber = array[i];
        else if (array[i] <= MinNumber)
            MinNumber = array[i];
    }
    int sum = MaxNumber - MinNumber;
    return sum;
}
Console.Clear();
int n = new Random().Next(5, 11);
int[] array = new int[n]; // {0, 0,....}
InputArray(array);
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Разница между Max и Min элемнтом массива составляет {ReleaseArray(array)}");