// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число A");
int A= int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B");
int B= int.Parse(Console.ReadLine());

int sum = 1;

for (int i=0; i<B; i++)
{
    sum=sum*A;
}
    System.Console.WriteLine(sum);