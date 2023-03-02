// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.

// c  = 2, a = 5, d = 4, b = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите a");
var a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b");
var b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите c");
var c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите d");
var d = Convert.ToDouble(Console.ReadLine());

double x = 0;
double y = 0;
x = ((d - c) / (a - b));
y = (a * (d-c)/(a-b)+c);
Console.WriteLine(x);
Console.WriteLine(y);
