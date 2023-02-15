 // Задача 8: Напишите программу, которая на вход принимает число (N),
//  а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");
string? answer = Console.ReadLine();
int n = Convert.ToInt32(answer);
int i = 1;
while (i <= n)
{

 if (i % 2 == 0)

 {
    
    Console.WriteLine(i);
    i++;
 }   
else i++;

}
