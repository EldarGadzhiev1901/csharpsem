// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

if (N>9999)
{int a = N % 10;
int b = (N/10) % 10;
int c = (N/1000)% 10;
int d = (N/10000)% 10;
if (a==d && b==c)
{
    Console.WriteLine("Число палиндром");
}
else Console.WriteLine("Число не палиндром");
 }

else Console.WriteLine("Число не пятизначно");