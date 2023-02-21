// // Задача 28: Напишите программу, которая принимает
// на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;

}

int Sum (int a)
{
    int s = 1;
    for(int i = 1; i<=a; i++)
    {
        s = s * i;

    }
    
    return s;

}

int number = ReadNumber("Введите число а");
int result = Sum(number);
Console.Write(result);