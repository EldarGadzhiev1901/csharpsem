// int number = 100;
// // число четное и больше 10

// if(number % 2 ==0 && number > 10)

// {
//     Console.WriteLine("условие выполнено")
// }

Console.WriteLine("Введите число");     
int na = Convert.ToInt32(Console.ReadLine());
if(na % 7 ==0 && na % 23 == 0)
{
    Console.WriteLine("Условие выполнено");
}
else Console.WriteLine("Условие не выполнено");