// Напишите программу, которая на вход принимает координаты двух точек 
// и находит растояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5,0); B (1,-1,9), -> 11.53

Console.Clear();

double Dist(int x1, int y1, int c1, int x2, int y2, int c2)
{
    double result;

    result = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(c2-c1,2));

    return result;

}

Console.Write("Введите Х координаты точки А: ");
int x1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y координаты точки А: ");
int y1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите C координаты точки А: ");
int c1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите Х координаты точки B: ");
int x2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y координаты точки B: ");
int y2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите C координаты точки А: ");
int c2 = int.Parse(Console.ReadLine()!);

Console.Write($"Длина отрезка АВ равна : {Dist(x1,y1,c1,x2,y2,c2):f2}");