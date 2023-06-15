// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] CreateArray(int rows, int columns, int depth)
{
    int[,,] array = new int[rows, columns, depth];
    for (int i = 0; i < array.GetLength(2); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                array[j, k, i] = new Random().Next(1, 10);
            }
        }
    }

    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(2); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                Console.Write(array[j, k, i] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int rows = 2;
int columns = 3;
int depth = 2;
int[,,] matrix = CreateArray(rows, columns, depth);
PrintArray(matrix);