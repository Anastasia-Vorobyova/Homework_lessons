// программа, которая принимает на вход 3х значное число и на выходе показывает 2ю цифру этого числа
Console.WriteLine ("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
string some_string;
if (number >=100 && number<1000)
{
    some_string = Convert.ToString(number);
    Console.WriteLine(some_string[1]); 
}
else
{
    Console.WriteLine("Error");
}