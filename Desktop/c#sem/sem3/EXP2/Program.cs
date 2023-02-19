// double a = 4;
// double b = 2;

// double c = Math.Pow(a, 0,5);

// Console.WriteLine(c);

// double d = Math.Sqrt(c);
// Console.WriteLine(d);

// Напишите программу, которая принимает на
//  вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// AB = √((xb - xa)2 + (yb - ya)2).

// Console.WriteLine("введите координаты по оси x первой точки");
// double x1 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("введите координаты по оси y первой точки");
// double y1 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("введите координаты по оси x второй точки");
// double x2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("введите координаты по оси y второй точки");
// double y2 = Convert.ToDouble(Console.ReadLine());

// double c = Math.Sqrt(Math.Pow (x2 - x1 , 2) + Math.Pow (y2 - y1 , 2));


// Console.WriteLine(c);

double ReadNumber(string? messageToUser)
{
    Console.WriteLine(messageToUser);
    double value = double.Parse(Console.ReadLine());
    return value;
}

double xa = ReadNumber("Введите координату точки A по X");
double ya = ReadNumber("Введите координату точки A по Y");
double xb = ReadNumber("Введите координату точки B по X");
double yb = ReadNumber("Введите координату точки B по Y");

double res = Math.Sqrt(Math.Pow(xa-xb, 2)+ Math.Pow (ya - yb, 2));
Console.WriteLine(res);
