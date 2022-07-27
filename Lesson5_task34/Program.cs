// Задайте массив заполненный случайными положительными трёхзначными числами.программу, 
//которая покажет количество чётных чисел в массиве.

int [] array = new int [10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(99, 1000);
}

System.Console.WriteLine(String.Join(", ", array));

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if ((array[i])%2==0)
    {
        count++;
    }
    
}
Console.WriteLine(count);