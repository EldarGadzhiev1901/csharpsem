// Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число"); 
string? answer = Console.ReadLine();     
int na = Convert.ToInt32(answer);
int result = - 1;

if (na > 99 && na< 1000)

{
    while (na > 99)
    {
        na = na / 10;

    }
    result = na % 10;
    Console.Write(result);
}
else Console.WriteLine ("Введено неправильное число");