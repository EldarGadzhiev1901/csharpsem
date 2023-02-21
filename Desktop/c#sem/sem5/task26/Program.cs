// Задача 26: Напишите программу, которая принимает на вход число и
// выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;

}

int Count (int a)
{
    int i = 0;
    while (a>0)
    {
        a = a / 10;
        i++;
    }
    return i;

}

int a = ReadNumber("Введите число а");
int result = Count(a);
Console.Write(result);
