Console.WriteLine("Введите первое число");
string answer = Console.ReadLine();
int na = Convert.ToInt32(answer);

Console.WriteLine("Введите второе число");

string answer2 = Console.ReadLine();
int nb = Convert.ToInt32(answer2);

if (na == (nb * nb))
{
    Console.WriteLine("True");

}
else  Console.WriteLine("False");


