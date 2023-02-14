// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, 
// какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число");
string? answer = Console.ReadLine();
int na = Convert.ToInt32(answer);

Console.WriteLine("Введите второе число");

string? answer2 = Console.ReadLine();
int nb = Convert.ToInt32(answer2);

if (na>nb)
{
    Console.Write("max = ");
    Console.WriteLine (na);
    Console.Write ("min = ");
    Console.WriteLine (nb);
}

if (nb>na)
{
        Console.Write("max = ");
    Console.WriteLine (nb);
    Console.Write ("min = ");
    Console.WriteLine (na);
}
