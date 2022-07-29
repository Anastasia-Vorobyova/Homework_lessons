// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int [] array = new int [20];
float min;
float max;
float diff;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,90);
}

max = array.Max();
min = array.Min();
diff = max-min;

Console.WriteLine(String.Join(", ", array));

System.Console.WriteLine("Разница между мин макс "+diff);


