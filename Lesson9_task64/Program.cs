//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N

void FindSum(int m, int n, int sum = 0)
{

    if (m > n)
    {
        System.Console.WriteLine("сумма элементов " + sum);
        return;
    }

    FindSum(m + 1, n, sum += m);
    return;
}

FindSum(4, 8);