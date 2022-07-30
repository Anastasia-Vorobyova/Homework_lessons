// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2

int count = 0;
int [] array = new int [5];

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите число");
    array[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < array.Length; i++)
{ 
    if (array[i] > 0)
    {
        count+=1;
    }
    
}
Console.WriteLine("Количество положительных цифр "+ count);