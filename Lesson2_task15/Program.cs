// программа, которая принимает на вход цифру, обозначающую день недели, и проверяет является ли этот день выходным
Console.WriteLine ("Введите цифру от 1 до 7, соответствующую дню недели");
int day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("День недели: ");

if(day>=1 && day<=5)
{
    if (day ==1)
    {
    Console.WriteLine ("понедельник"); 
    }
    else if (day ==2)
    {
    Console.WriteLine ("вторник"); 
    }
    else if (day ==3)
    {
    Console.WriteLine ("среда"); 
    }
    else if (day ==4)
    {
    Console.WriteLine ("четверг"); 
    }
    else if (day ==5)
    {
    Console.WriteLine ("пятница"); 
    }
}
else if(day==6 || day==7)
{
Console.WriteLine("Выходной ");
    if (day ==6)
    {
    Console.WriteLine ("суббота"); 
    }
    else if (day ==7)
    {
    Console.WriteLine ("воскресенье"); 
    }
}
