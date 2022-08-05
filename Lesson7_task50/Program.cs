// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 9);
        }
    }
    return array;
}

void CheckArray(int[,] array, int row, int column)
{
    if (row <= array.GetLength(0) && column <= array.GetLength(1))
    {
        System.Console.WriteLine("Нужное число " + array[row, column]);
    }
    else
    {
        System.Console.WriteLine("Такого числа нет");
    }
}

void PrintMatrix(int[,] mtrx)
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

System.Console.WriteLine("Введите строку до 10");
int row = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите столбец до 10");
int column = Convert.ToInt32(System.Console.ReadLine());

if (row <= 0 || row > 10 || column <=0 || column > 10)
{
    System.Console.WriteLine("Введено некорректное значение ");
}
else
{
    int[,] arr = FillArray(10, 10);
    PrintMatrix(arr);
    CheckArray(arr, row - 1, column - 1);
}

