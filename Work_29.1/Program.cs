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

// решение задачи от преподователя
// Console.WriteLine("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите элементы массива через пробел: ");
// int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

// Console.WriteLine("Введите коэффициент сдвига: ");
// int k = Convert.ToInt32(Console.ReadLine());
// k %= n; // k = k % n
// int[] result = new int[n];
// if (k > 0)
// {
//     for (int i = 0; i < k; i++)
//         result[i] = numbers[n - k + i];
//     for (int i = 0; i < n - k; i++)
//         result[k + i] = numbers[i];
// }
// else
// {
//     k = (-1) * k;
//     for (int i = 0; i < k; i++)
//         result[n - k + i] = numbers[i];
//     for (int i = 0; i < n - k; i++)
//         result[i] = numbers[k + i];
// }
// Console.WriteLine(string.Join(" ", result));


//Доработка от меня
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 106);
}

Console.Clear();
Console.WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[n];
InputArray(numbers);

Console.WriteLine($"Начальный массив: [{string.Join(", ", numbers)}]");
Console.WriteLine("Введите коэффициент сдвига от 1 до 105: ");
int k = Convert.ToInt32(Console.ReadLine());
k %= n; // k = k % n
int[] result = new int[n];
if (k > 0)
{
    for (int i = 0; i < k; i++)
        result[i] = numbers[n - k + i];
    for (int i = 0; i < n - k; i++)
        result[k + i] = numbers[i];
}
else
{
    k = (-1) * k;
    for (int i = 0; i < k; i++)
        result[n - k + i] = numbers[i];
    for (int i = 0; i < n - k; i++)
        result[i] = numbers[k + i];
}
Console.WriteLine(string.Join(" ", result));