// Задача 29: Напишите программу, которая спрашивает 
// у пользователя кол-во элементов массива, затем сами элементы. 
// Программ должна вывести массив на экран.
// 8
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

//способ 1
// Console.Clear();
// Console.WriteLine("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// Console.WriteLine("Введите элементы массива: ");
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine($"Введнный массив: [{string.Join(", ", array)}]");


//способ 2
void InputArray(int[] array)
{
    Console.WriteLine("Введите элементы массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        // Console.WriteLine("Введите элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.Clear();
Console.WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Введнный массив: [{string.Join(", ", array)}]");
