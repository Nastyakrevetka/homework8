//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void ProductMatrix(int[,] matrix1, int[,] matrix2, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < matrix1.GetLength(1); k++)
      {
        sum += matrix1[i,k] * matrix2[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}
int EnterNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int rows = EnterNumber("введите число строк 1 матрицы: ");
int colums = EnterNumber("введите число столбцов 1 матрицы = число строк 2 матрицы: ");
int line =EnterNumber("введите число столбцов 2 матрицы: ");
int[,] matrix1 = new int[rows, colums];
Console.WriteLine();
FillArray(matrix1);
PrintArray(matrix1);
Console.WriteLine();
int[,] matrix2 = new int[colums, line];
Console.WriteLine();
FillArray(matrix2);
PrintArray(matrix2);
Console.WriteLine();

int[,] resultMatrix = new int[rows,line];

ProductMatrix(matrix1, matrix2, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
PrintArray(resultMatrix);
