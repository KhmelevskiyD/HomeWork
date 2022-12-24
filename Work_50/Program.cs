// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такой позиции в массиве нет

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void PositionNumMatrix(int[,] matrix, int[] position)
{
    if (position[0] < matrix.GetLength(0) || position[1] < matrix.GetLength(1))
    {
    Console.Write("Значение текущей ячейки равно: ");
    Console.Write($"{matrix[position[0], position[1]]}");
    }
    else Console.WriteLine($"[{string.Join(", ", position)}] -> Такой позиции нет в массиве ");
}

Console.Clear();
// Console.Write("Введите размеры матрицы через пробел: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
int[,] matrix = new int[5, 5];
Console.Write("Введите позицию в матрице через пробел: ");
int[] position = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
InputMatrix(matrix);
PositionNumMatrix(matrix, position);
