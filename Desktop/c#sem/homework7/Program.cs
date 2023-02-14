// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число");

string? answer = Console.ReadLine();
int n = Convert.ToInt32(answer);

if (n == 1)Console.WriteLine("Monday");
if (n == 2)Console.WriteLine("Tuesday");
if (n == 3)Console.WriteLine("Wednesday");
if (n == 4)Console.WriteLine("Thursday");
if (n == 5)Console.WriteLine("Friday");
if (n == 6)Console.WriteLine("Saturday");
if (n == 7)Console.WriteLine("Sunday");
if (n > 7) Console.WriteLine("Time paradox");
if (n > 5 && n < 8) Console.WriteLine("Holiday. Stay home and rest");
if (n > 0 && n < 6) Console.WriteLine("Go to work");
