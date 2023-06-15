// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int rows = 4;
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

void MinSumRow(int[,] array)
{
    int minSum = Int32.MaxValue;
    int minSumRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        Console.WriteLine($"Сумма элементов в строке {i + 1} равна {sum}");
        if (sum < minSum)
        {
            minSum = sum;
            minSumRow = i;
        }
    }
    Console.WriteLine($"Минимальная сумма элементов найдена в строке {minSumRow + 1}");
}

MinSumRow(result);