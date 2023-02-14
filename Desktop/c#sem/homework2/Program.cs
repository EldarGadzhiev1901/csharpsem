// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
Console.WriteLine("Введите первое число");
string? answer = Console.ReadLine();
int na = Convert.ToInt32(answer);

Console.WriteLine("Введите второе число");

string? answer2 = Console.ReadLine();
int nb = Convert.ToInt32(answer2);

Console.WriteLine("Введите третье число");

string? answer3 = Console.ReadLine();
int nc = Convert.ToInt32(answer3);

if (na>nb)
{
    Console.Write("max = ");
    Console.WriteLine (na);
   
}

if (nc>na)
{
        Console.Write("max = ");
    Console.WriteLine (nc);
  
}

if (nb>nc)
{
        Console.Write("max = ");
    Console.WriteLine (nb);
   
}
