// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] array = new int [8];
int length = array.Length;

for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(0, 8);
}

foreach (var item in array)
{
  Console.WriteLine(item + " ");  
}

