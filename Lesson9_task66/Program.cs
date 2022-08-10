// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.


int AcermanFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else

        if (m != 0 && n == 0)
    {
        return AcermanFunc(m - 1, 1);
    }
    else
    {
        return AcermanFunc(m - 1, (AcermanFunc(m, n - 1)));
    }

}

System.Console.WriteLine("Итоговое число " + AcermanFunc(2, 3));