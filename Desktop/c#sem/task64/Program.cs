// Задача 64: Задайте значение N.
//  Напишите программу, которая выведет 
//  все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int number = 9;
int number2 = 1;
string numbers(int n, int m)
{
    if (n == m) return $"{n}";
    if (n == 1) return "1";
    string x = numbers(n, m+1) + " " + m;
    return x;
}

Console.WriteLine(numbers(number, number2));