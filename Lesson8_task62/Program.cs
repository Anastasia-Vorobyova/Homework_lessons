// Задача 62. Заполните спирально массив 4 на 4.

int[,] GetMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int maxNumber = 1;

    for (int delta = 0; delta < rows - 2; delta++)
    {
        for (int i = 0 + delta; i < rows - delta; i++)
        {
            matrix[0 + delta, i] = maxNumber;
            maxNumber++;
        }
        maxNumber--;
        for (int i = 0 + delta; i < rows - delta; i++)
        {
            matrix[i, rows - 1 - delta] = maxNumber;
            maxNumber++;
        }
        maxNumber--;
        for (int i = rows - 1 - delta; i >= 0 + delta; i--)
        {
            matrix[rows - 1 - delta, i] = maxNumber;
            maxNumber++;
        }
        maxNumber--;
        for (int i = rows - 1 - delta; i >= 1 + delta; i--)
        {
            matrix[i, 0 + delta] = maxNumber;
            maxNumber++;
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
int N = 4;
int[,] array = GetMatrix(N, N);
PrintMatrix(array);
System.Console.WriteLine();