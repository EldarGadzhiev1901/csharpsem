// Задача 6: Напишите программу, которая на вход принимает число и выдает, 
// является ли число четным (делится ли оно на два без остатка).
Console.WriteLine("Введите число");
string? answer = Console.ReadLine();
int na = Convert.ToInt32(answer);

if (na % 2 == 0)

{
    Console.WriteLine ("Число четное");
}
else Console.WriteLine ("Число нечетное");

