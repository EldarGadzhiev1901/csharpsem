// Задача 63: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int number = 9;
string numbers(int n)
{
    if (n == 1) return "1";
    string x = numbers(n - 1) + " " + n;
    return x;
}

Console.WriteLine(numbers(number));