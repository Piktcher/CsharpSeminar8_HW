// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int rows = 3;
int columns = 4;
int[,] matrix = new int[rows, columns];

int[,] CreateArray(int rows, int columns)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 100);
        }
    }

    return matrix;
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

int[,] result = CreateArray(rows, columns);
PrintArray(result);

int[,] SortArrayRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < (array.GetLength(1) - 1); j++)
        {
            int maxPos = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, j]) maxPos = k;
            }
            int temp = array[i, j];
            array[i, j] = array[i, maxPos];
            array[i, maxPos] = temp;
        }
    }
    return array;
}

int[,] result2 = SortArrayRows(result);
Console.WriteLine();
PrintArray(result2);