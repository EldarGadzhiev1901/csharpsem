// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.WriteLine("Введите первое число");
string? answer = Console.ReadLine();
int na = Convert.ToInt32(answer);

Console.WriteLine("Введите второе число");

string? answer2 = Console.ReadLine();
int nb = Convert.ToInt32(answer2);

if (na == (nb * nb) || nb == (na * na))
{
    Console.WriteLine("True");

}
else  Console.WriteLine("False");