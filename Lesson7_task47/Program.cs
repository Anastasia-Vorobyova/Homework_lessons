// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.   0,5 7 -2 -0,2      1 -3,3 8 -9,9      8 7,8 -7,1 9

System.Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] GetMatrix(int rows, int columns)
{
    var rand = new Random();
    double[,] matrix = new double[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = rand.Next(-20, 21)/10.0;
    }
    System.Console.WriteLine();

    return matrix;
}

void PrintMatrix(double[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            System.Console.Write($"{mtrx[i, j],3} | ");
        }
        System.Console.WriteLine();

    }
}

PrintMatrix(GetMatrix(rows, columns));