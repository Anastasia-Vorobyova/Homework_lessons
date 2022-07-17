//программа, которая принимает на вход 5значное число и проверяет, является ли оно палиндромом

Console.WriteLine("Введите число ");
int numberStart;

try
{
    numberStart = Convert.ToInt32(Console.ReadLine());
}
catch (System.Exception)
{
    Console.WriteLine("Необходимо ввести число");
    throw;
}

if(numberStart>9999 && numberStart<=99999)
{

    String numberStr = numberStart.ToString();
    char[] numberStartReverse = numberStr.ToCharArray();
    Array.Reverse(numberStartReverse);
    numberStr = new string (numberStartReverse);
    int convertNumber = Convert.ToInt32(numberStr);

        if(numberStart == convertNumber)
        {
            Console.WriteLine("Число палиндром");
        }
        else
        {
            Console.WriteLine("Число не палиндром");
        }

}
else
{
    Console.WriteLine("Ошибка: Число должно быть 5ти значным");
}
