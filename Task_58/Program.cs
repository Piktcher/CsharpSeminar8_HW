// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] CreateMulipliedMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] multipliedMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int k = 0; k < matrix2.GetLength(1); k++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                multipliedMatrix[i,k] += matrix1[i, j] * matrix2[j, k];
            }
        }
    }
    return multipliedMatrix;
}

int rows = 2;
int columns = 3;
int[,] matrix = CreateArray(rows, columns);
PrintArray(matrix);
Console.WriteLine();

int rows2 = 3;
int columns2 = 2;
int[,] matrix2 = CreateArray(rows2, columns2);
PrintArray(matrix2);
Console.WriteLine();

if (columns == rows2)
{
    int[,] multipliedMatrix = CreateMulipliedMatrix(matrix, matrix2);
    PrintArray(multipliedMatrix);
}
else Console.WriteLine("Ошибка. Матрицы можно умножать, только если они согласованы");


