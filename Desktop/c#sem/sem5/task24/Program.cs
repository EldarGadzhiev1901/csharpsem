// Принимаем на входе число N, выводим сумму чисел от 1 до N

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;

}

int Sum (int a)
{
    int s = 0;
    for(int i = 1; i<=a; i++)
    {
        s = s + i;

    }
    
    return s;

}

int number = ReadNumber("Введите число а");
int result = Sum(number);
Console.Write(result);