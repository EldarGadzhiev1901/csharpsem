// Задача 65: Задайте значения M и N. 
// Напишите программу, которая выведет все 
// натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

int n1 = 4;
int n2 = 9;
string numbers(int n,int m)
{
    if (n == 1) return "1";
    if (n == m) return "";
  
    string x = numbers(n,m-1) + " " + m;
    return x;
}

Console.WriteLine(numbers(n1,n2));