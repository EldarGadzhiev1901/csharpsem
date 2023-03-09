// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы.

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
int MatrixTurn(int[,] sourceMatrix)
{
    int[,] newMatrix = new int[sourceMatrix.GetLength(1), sourceMatrix.GetLength(0)];
    for (int i=0;i<newMatrix.GetLength(0); i++)
    {
        for (int j=0;j<newMatrix.GetLength(1); j++)
        {
            newMatrix[i,j] = newMatrix[j,i];
        }
    }
    return newMatrix;
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
int[,] MatrixTurn = MatrixTurn(myMatrix);
PrintMatrix(myMatrix);