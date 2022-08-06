// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//массив размером 2 x 2 x 2
//12(0,0,0) 22(0,0,1)
//45(1,0,0) 53(1,0,1)

int[,,] GetMatrix(int rows, int columns, int column2, int min, int max)
{
    int[,,] matrix = new int[rows, columns, column2];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = rnd.Next(min, max);
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write("(" + i + " " + j + " " + k + ")" + "\t");
                Console.Write(matrix[i, j, k] + "\t");

            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] array = GetMatrix(2, 2, 2, 10, 100);
System.Console.WriteLine();
PrintMatrix(array);
