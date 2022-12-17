// Суперсдвиг. Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю 
// последовательность (сдвиг - циклический) на |K| элементов вправо, если 
// K – положительное и влево, если отрицательное.

// Первая строка содержит натуральное число N, во второй 
// строке записаны N целых чисел Ai, а в последней – целое число K. 
// (1 ≤ N ≤ 105, |K| ≤ 105, |Ai| ≤ 100).

// 5
// 5 3 7 4 6       7 4 6 5 3
// 3	

// 5
// 5 3 7 4 6       4 6 5 3 7
// -3	

void PrintArray(int[] array)
{
    int count = array.Length;
    int k = new Random().Next(-105, 105);
    Console.WriteLine($"Число К: {k}");
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 101);
}

// void ReleaseArray(int[] array)
// {   
//     for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
//         Console.Write($"{array[i] * array[array.Length - 1 - i]} ");
// }

void ReleaseArray(int[] array)
{
    int k = new Random().Next(-105, 105);
    Console.WriteLine($"Число К: {k}");
    if (k>=0)
    {
    for (int i = array.Length; i >= 0; i--)
    {
        int temporary = array[i];
        array[i] = array[i+k];
        array[i+k] = temporary;

        
        // int minPosition = i;
        // for (int j = i + 1; j < array.Length; j++)
        // {
        //     if (array[j] < array[minPosition]) minPosition = j;
        // }
        // int temporary = array[i];
        // array[i] = array[minPosition];
        // array[minPosition] = temporary;
    }
    }
    // if (k<0)
    // {
    // for (int i = 0; i < array.Length; i++)
    // {
    //     int temporary = array[i];
    //     array[i] = array[i+k];
    //     array[i+k] = temporary;
        
        
        // int minPosition = i;
        // for (int j = i + 1; j < array.Length; j++)
        // {
        //     if (array[j] < array[minPosition]) minPosition = j;
        // }
        // int temporary = array[i];
        // array[i] = array[minPosition];
        // array[minPosition] = temporary;
    // }
    Console.WriteLine();
    // }
}


Console.Clear();
// int k = new Random().Next(-105, 105);
// Console.WriteLine($"Число К: {k}");
int n = new Random().Next(1, 105);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// ReleaseArray(array);
PrintArray(array);
// Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");
// Console.WriteLine(ReleaseArray(array));









// Сортировка массива
// int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

// void PrintArray(int[] array)
// {
//     int count = array.Length;

//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;
//         for (int j = i + 1; j < array.Length; j++)    
//         {
//             if (array[j] < array[minPosition]) minPosition = j;
//         }
//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array [minPosition] = temporary;


//     }
//     Console.WriteLine();
// }

// PrintArray(arr);

// SelectionSort(arr);
// PrintArray(arr);