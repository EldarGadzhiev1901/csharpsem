// Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.

//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//  и возвращает значение этого элемента или же указание, 
//  что такого элемента нет.

int ReadNumber(string MessageToUser)
{
    Console.WriteLine(MessageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] GetRandomMatrix(int rows, int columns, int leftborder = 0, int rightborder = 10)
{
    int[,] matrix = new int[rows, columns];


    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(leftborder, rightborder + 1);

        }

    }
    return matrix;
}
void Avg(int[,] matrix, int m, int n)
{
    
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        
        double average = 0;
        
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            average = average + matrix[i,j];
         

        }
           average = average / m;
         Console.Write(average + " | ");
    }
      
}
    

             
    
            






void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();

    }

}
int m = ReadNumber("Строки");
int n = ReadNumber("Столбцы");
int[,] myMatrix = GetRandomMatrix(m, n);
PrintMatrix(myMatrix);
Console.WriteLine();
Avg(myMatrix, m, n);


