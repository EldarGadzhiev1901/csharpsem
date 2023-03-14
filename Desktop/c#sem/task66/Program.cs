// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

int number = 4;
int number2 = 8;
int numbers(int n, int m)
{
 int sum = 0;
    
    
    if (n == m) return n;
    sum = numbers(n, m-1) + m;
    return (sum);
}

Console.WriteLine(numbers(number, number2));