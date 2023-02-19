// // задача 17

// Console.WriteLine("введите координаты по оси x");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("введите координаты по оси y");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0)
// {
//     Console.WriteLine("Точка в первой координатной четверти");
// }
// else if (x > 0 && y < 0)
// {
//        Console.WriteLine("Точка во второй координатной четверти");
// }

// else if (x < 0 && y < 0)

// {
//        Console.WriteLine("Точка в третьей координатной четверти");
// }

// else if (x < 0 && y > 0)

// {
//          Console.WriteLine("Точка в четвертой координатной четверти");
// }

// else     Console.WriteLine("Ошибка");

int ReadNumber(string? messageToUser)
{
       Console.WriteLine(messageToUser);
       int value = Convert.ToInt32(Console.ReadLine());
       return value;
}

int x = ReadNumber("Введите координату точки по xa");
int y = ReadNumber("Введите координату точки по ya");
// int xb ReadNumber("Введите координату точки по xb")
// int yb ReadNumber("Введите координату точки по yb")

Console.WriteLine(
       x > 0 && y > 0? "Точка в 1 четверти":
       x > 0 && y > 0? "Точка в 2 четверти":
       x > 0 && y > 0? "Точка в 3 четверти":
       x > 0 && y > 0? "Точка в 4 четверти":
       "подумай еще"
       );
