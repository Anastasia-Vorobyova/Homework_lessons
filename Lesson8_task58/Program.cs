// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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

int[,] MultElementsInTwoMatrix(int[,] matrix1, int [,] matrix2)
{
    int[,] newMatrix = new int[matrix1.GetLength(0),matrix1.GetLongLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            newMatrix[i,j] = matrix1[i,j]*matrix2[i,j];
        }
    }
    return newMatrix;
}

int[,] array1 = GetMatrix(4, 4, 1, 100);
int[,] array2 = GetMatrix(4, 4, 1, 100);
System.Console.WriteLine("Массив 1 ");
PrintMatrix(array1);
System.Console.WriteLine();
System.Console.WriteLine("Массив 2 ");
PrintMatrix(array2);
System.Console.WriteLine();
System.Console.WriteLine("Результат перемножения ");
PrintMatrix(MultElementsInTwoMatrix(array1, array2));
