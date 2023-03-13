// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

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

void MatrixXMatrix(int[,] matrix1, int[,] matrix2, int[,] matrix3)
{
  for (int i = 0; i < matrix3.GetLength(0); i++)
  {
    for (int j = 0; j < matrix3.GetLength(1); j++)
    {
      int sum = 0;

      {
        sum += matrix1[i,j] * matrix2[i,j];
      }
      matrix3[i,j] = sum;
    }
  }
}
int m = ReadNumber("Строки");
int n = ReadNumber("Столбцы");
int[,] myMatrix = GetRandomMatrix(m, n);
int[,] myMatrix2 = GetRandomMatrix(m,n);
PrintMatrix(myMatrix);
Console.WriteLine("--------------------");
PrintMatrix(myMatrix2);
int[,] myMatrix3 = new int [m,n];

MatrixXMatrix(myMatrix, myMatrix2, myMatrix3);
Console.WriteLine("--------------------");
PrintMatrix(myMatrix3);