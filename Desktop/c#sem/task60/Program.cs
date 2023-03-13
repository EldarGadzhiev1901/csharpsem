// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int ReadNumber(string MessageToUser)
{
    Console.WriteLine(MessageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[, ,] GetRandomMatrix(int rows, int columns, int third, int leftborder = 10, int rightborder = 99)
{
    int[, ,] matrix = new int[rows, columns, third];


    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
                  for (int k = 0; k < matrix.GetLength(2); k++)
        {
            matrix[i, j, k] = Random.Shared.Next(leftborder, rightborder + 1);

        }

    }
   
}
 return matrix;
}
void PrintMatrix(int[, ,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
                  for (int k = 0; k < matrix.GetLength(2); k++)
        {
            Console.Write(matrix[i, j, k] + " ");
        }
        Console.WriteLine();

    }

}
}

void Coordinats(int[, ,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
                  for (int k = 0; k < matrix.GetLength(2); k++)
        {
            Console.Write($" {matrix[i,j,k]} ({i}, {j}, {k}) ");
        }
        Console.WriteLine();

    }

}
}

int m = ReadNumber("Строки");
int n = ReadNumber("Столбцы");
int z = ReadNumber("Что то третье");
int[, ,] myMatrix = GetRandomMatrix(m, n, z);

Coordinats(myMatrix);
