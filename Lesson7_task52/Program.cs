// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
void SumAverage(int[,] array)
{ double sumAver = 0;
    int indexRow=0;
    int indexColumn=1;
    if(array.GetLength(0)==array.GetLength(1)){
            indexRow=0;
            indexColumn=1;
    }
    else{
        indexRow=1;
        indexColumn=0;
    }

    for (int j = 0; j < array.GetLength(indexRow); j++)
    {
        for (int i = 0; i < array.GetLength(indexColumn); i++)
        {
            sumAver += array[i,j];    
        }
        System.Console.WriteLine("среднее арифметическое столбца "+sumAver/array.GetLength(indexColumn));
        sumAver = 0;
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

System.Console.WriteLine("Введите количество строк");
int row = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int column = Convert.ToInt32(System.Console.ReadLine());

int[,] arr = FillArray(row, column);
PrintMatrix(arr);
SumAverage(arr);
