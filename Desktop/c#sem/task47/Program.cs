// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет 
// местами первую и последнюю строку массива.

int ReadNumber(string MessageToUser)
{
    Console.WriteLine(MessageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

double[,] GetRandomMatrix(int rows, int columns)
{
    double[,] matrix = new double[rows, columns];


    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.NextDouble(); 

        }

    }
    return matrix;
}



void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write( matrix[i, j] + " " );
            
        }
        Console.WriteLine();

    }

}
int m = ReadNumber("Строки");
int n = ReadNumber("Столбцы");
double[,] myMatrix = GetRandomMatrix(m, n);

PrintMatrix(myMatrix);

Console.WriteLine();

// Я сломал голову, как отформатировать количество знаков, после запятой((((