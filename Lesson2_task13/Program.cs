// программа, которая выводит 3ю цифру числа, или сообщает, что 3й цифры нет
Console.WriteLine ("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
string some_string;
if (number > 0)
{
   Console.WriteLine("Ввели число "+ number);
   if (number>=100) 
   {
    some_string = Convert.ToString(number);
    Console.WriteLine ("Третье число ");
    Console.WriteLine(some_string[2]); 
   } 
   else
{
    Console.WriteLine("Третьей цифры нет");
}
}
else
{
    Console.WriteLine("Число меньше 1");
}
