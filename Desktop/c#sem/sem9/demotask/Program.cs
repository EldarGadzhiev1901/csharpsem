// вычислить факториал введенного числа
// 4-> 24
// 5-> 120

int number = -5;
int factorial(int n)
{
    if (n<0) throw new Exception($"Cannot find factorial of {n}");
    if (n==0) return 1;
    if (n==1) return 1;
    int res = n * factorial(n-1);
    return res;
}

Console.WriteLine(factorial(number));