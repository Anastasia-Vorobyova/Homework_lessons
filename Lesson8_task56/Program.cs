// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.


int[,] array = GetMatrix(4, 4, 1, 100);
PrintMatrix(array);
System.Console.WriteLine();
System.Console.WriteLine("минимальная сумма элементов в строке  " + FindMinSumRow(array));

int[,] GetMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int FindMinSumRow(int[,] array)
{
    int minSumRow = 0;
    int sumRow = SumRowElements(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int temp = SumRowElements(array, i);

        if (sumRow > temp)
        {
            sumRow = temp;
            minSumRow = i;
        }
    }

    int SumRowElements(int[,] array, int i)
    {
        int sumRow = array[i, 0];
        for (int j = 1; j < array.GetLength(1); j++)
        {
            sumRow += array[i, j];
        }
        return sumRow;
    }
    return minSumRow + 1;
}