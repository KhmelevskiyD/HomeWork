// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(1, 10); // [1, 9]
//     }
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i, j]} \t");
//         Console.WriteLine();
//     }
// }

// void SumMatrix(int[,] matrix1, int[,] matrix2)
// {
//     for (int i = 0; i < matrix1.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix1.GetLength(1); j++)
//         {
//             matrix1[i, j] *= matrix2[i, j];
//         }
//     }
// }

// Console.Clear();
// Console.Write("Введите размер 1-ой матрицы через пробел: ");
// int[] size1 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// Console.Write("Введите размер 2-ой матрицы через пробел: ");
// int[] size2 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// if (size1[0] != size2[0] && size1[1] != size2[1])
// {
//     Console.Write("Вы ошиблись, матрицы должны совпадать.");
//     Console.WriteLine("Введите размер 1-ой матрицы через пробел: ");
//     size1 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
//     Console.WriteLine("Введите размер 2-ой матрицы через пробел: ");
//     size2 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// }
// int[,] matrix1 = new int[size1[0], size1[1]];
// int[,] matrix2 = new int[size2[0], size2[1]];

// Console.WriteLine();
// Console.WriteLine("Начальный массив 1:");
// InputMatrix(matrix1);
// PrintMatrix(matrix1);
// Console.WriteLine();
// Console.WriteLine("Начальный массив 2:");
// InputMatrix(matrix2);
// PrintMatrix(matrix2);
// Console.WriteLine();
// Console.WriteLine("Сумма матриц:");
// SumMatrix(matrix1, matrix2);
// PrintMatrix(matrix1);



// Решение преподователя
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

int[,] ReleaseMatrix(int[,] FirstMatrix, int[,] SecondMatrix)
{
    int[,] result = new int[FirstMatrix.GetLength(0), FirstMatrix.GetLength(1)];
    for (int i = 0; i < FirstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < FirstMatrix.GetLength(1); j++)
            result[i, j] = FirstMatrix[i, j] * SecondMatrix[i, j];
    }
    return result;
}

Console.Clear();
Console.Write("Введите размер матриц: "); // размеры матриц должны быть одинаковые
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] FirstMatrix = new int[size[0], size[1]];
int[,] SecondMatrix = new int[size[0], size[1]];
InputMatrix(FirstMatrix);
InputMatrix(SecondMatrix);
Console.WriteLine("Начальный массив 1: ");
PrintMatrix(FirstMatrix);
Console.WriteLine("Начальный массив 2: ");
PrintMatrix(SecondMatrix);
Console.WriteLine("Результат:");
PrintMatrix(ReleaseMatrix(FirstMatrix, SecondMatrix));