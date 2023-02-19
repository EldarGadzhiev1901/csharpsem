// задача 17

Console.WriteLine("введите номер четверти");

int n = Convert.ToInt32(Console.ReadLine());


if (n==1)
{
    Console.WriteLine("Координаты x > 0 y > 0 ");
}
else if (n==2)
{
       Console.WriteLine("Координаты x > 0  y < 0");
}

else if (n==3)

{
       Console.WriteLine("Координаты x < 0 && y < 0");
}

else if (n==4)

{
         Console.WriteLine("Координаты x < 0 y > 0");
}

else     Console.WriteLine("Подумай еще ");