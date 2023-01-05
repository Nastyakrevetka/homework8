
//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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
int FindSumRows(int[,] matr, int i)
{
  int sumRows = matr[i,0];
  for (int j = 1; j < matr.GetLength(1); j++)
  {
    sumRows += matr[i,j];
  }
  return sumRows;
}

int rows = EnterNumber("введите m: ");
int colums = EnterNumber("введите n: ");
int[,] matrix = new int[rows, colums];
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();

int minSumRows = 0;
int sumRows = FindSumRows(matrix, 0);
for (rows = 1; rows < matrix.GetLength(0); rows++)
{
  int tempSumRows = FindSumRows(matrix, rows);
  if (sumRows > tempSumRows)
  {
    sumRows = tempSumRows;
    minSumRows = rows;
  }
}
Console.WriteLine($"{minSumRows+1} - строкa с наименьшей суммой ({sumRows}) элементов ");



