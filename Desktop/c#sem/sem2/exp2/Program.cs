// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.WriteLine("Введите первое число"); 
string? answer = Console.ReadLine();     
int na = Convert.ToInt32(answer);

Console.WriteLine("Введите второе число");

string? answer2 = Console.ReadLine();
int nb = Convert.ToInt32(answer2);
int result = nb%na;

if (nb%na == 0)
{
    Console.WriteLine("Второе число кратно первому");
}
else Console.WriteLine(result);


