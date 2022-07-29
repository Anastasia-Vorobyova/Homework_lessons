// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

int [] array = new int [10];
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,10);
}

System.Console.WriteLine(String.Join(", ", array));

for (int i = 0; i < array.Length; i++)
{
    if (i%2 == 0) 
    {
    sum = sum + array [i];
    }     
}
Console.WriteLine("Вывод суммы " + sum);