//программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

void PrintShape(double ax, double ay, double az, double bx, double by, double bz)
{
    double deltaX = ax - bx; 
    double deltaY = ay - by; 
    double deltaZ = az - bz; 
    double c = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
    Console.WriteLine(c);
}
PrintShape(7,-5, -1, 1,-1,16);