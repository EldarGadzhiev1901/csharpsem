int ReadNumber(string MessageToUser)
{
    Console.WriteLine(MessageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] GetRandomMatrix(int rows, int columns, int leftborder = 0, int rightborder = 10)
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            matrix[i,j] = Random.Shared.Next(leftborder, rightborder+1);
        }   
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
     for (int i = 0; i<matrix.GetLength(0); i++)
     {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            Console.WriteLine(matrix[i, j] + " ");
        }
          Console.WriteLine();
    
     }
   
}
int m = ReadNumber("Строки");
int n = ReadNumber("Столбцы");
int[,] myMatrix = GetRandomMatrix(m,n);
PrintMatrix(myMatrix);
