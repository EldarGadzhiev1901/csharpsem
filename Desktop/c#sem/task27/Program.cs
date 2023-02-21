// Задача 27: Напишите программу, 
// которая принимает на вход число и выдаёт сумму цифр в числе

int ReadNumber(string messageToUser)
{
    
    Console.WriteLine(messageToUser);
    int value = int.Parse(Console.ReadLine());
    return value;

}

int Count (int a)
{
    int i = 1;
    int b = 0;
    while (a>0)
    
    {
        
       a = a / i;
       b = b + (a % 10);
       i = i * 10;
      
        
    }
    return b;

}


int a = ReadNumber("Введите число а");
int result = Count(a);
Console.Write(result);