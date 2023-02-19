// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет. (номер цифры считается от левого края)

Console.WriteLine("Введите число"); 
string? answer = Console.ReadLine();     
int na = Convert.ToInt32(answer);
int result = - 1;

if (na > 99)

{
    while (na > 999)
    {
        na = na / 10;

    }
    result = na % 10;
    Console.Write(result);
}
else Console.WriteLine ("Нет такой цифры");
