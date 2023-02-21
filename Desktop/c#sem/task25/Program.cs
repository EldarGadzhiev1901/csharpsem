int ReadNumber(string messageToUser)
{
    
    Console.WriteLine(messageToUser);
    int value = int.Parse(Console.ReadLine());
    return value;

}
int a = ReadNumber("Введите первое число");
int b = ReadNumber("Введите второе число");
int i = 1;
int res = a;
while (i<b)
{
    res = res * a;
    i++;
}
Console.WriteLine(res);