Console.WriteLine("Введите первое число"); 
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
else Console.WriteLine ("Нет такого числа");
    