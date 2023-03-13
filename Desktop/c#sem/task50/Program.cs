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
void DigitCheck(int[,] matrix, int i, int j)
{

 
 
    if (i< matrix.GetLength(0) && j<matrix.GetLength(1))
               
                Console.Write(matrix[i , j]);
               
               
            else Console.WriteLine("miss");
               
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
int a = ReadNumber("Строка поиска");
int b = ReadNumber("Столбец поиска");
DigitCheck(myMatrix, a, b);


// Не понимаю, почему он не выдает сообщение о том, 
// что я ввел не те числа? Число ищет, но не выдает оповещение о том, 
// что мы вышли за горизонт