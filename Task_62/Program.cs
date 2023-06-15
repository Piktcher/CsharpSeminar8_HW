// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateArray(int rows, int columns, int start, int step)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j < columns - 1)
            {
                array[i, j] = start;
                start += step;
            }
            else
            {
                for (i = i; i < array.GetLength(0); i++)
                {
                    if (i < rows - 1)
                    {
                        array[i, j] = start;
                        start += step;
                    }
                    else
                    {
                        for (j = j; j >= 0; j += -1)
                        {
                            if (j > 0)
                            {
                                array[i, j] = start;
                                start += step;
                            }
                            else
                            {
                                for (i = i; i >= 1; i += -1)
                                {
                                    if (i > 1)
                                    {
                                        array[i, j] = start;
                                        start += step;
                                    }
                                    else
                                    {
                                        for (j = j; j <= 2; j++)
                                        {
                                            if (j < 2)
                                            {
                                                array[i, j] = start;
                                                start += step;
                                            }
                                            else
                                            {
                                                for (i = i; i <= 2; i++)
                                                {
                                                    if (i < 2)
                                                    {
                                                        array[i, j] = start;
                                                        start += step;
                                                    }
                                                    else
                                                    {
                                                        for (j = j; j >= 1; j += -1)
                                                        {
                                                            array[i, j] = start;
                                                            start += step;
                                                        }
                                                        return array;
                                                    }
                                                }
                                                return array;
                                            }
                                        }
                                        return array;
                                    }
                                }
                                return array;
                            }
                        }
                        return array;
                    }


                }
                return array;
            }

        }
        return array;
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

int rows = 4;
int columns = 4;
int start = 01;
int step = 1;

int[,] result = CreateArray(rows, columns, start, step);
PrintArray(result);