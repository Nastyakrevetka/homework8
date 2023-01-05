//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
void ArrayNumberDecreasing(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      for (int k = 0; k < matr.GetLength(1) - 1; k++)
      {
        if (matr[i, k] < matr[i, k + 1])
        {
          int temp = matr[i, k + 1];
          matr[i, k + 1] = matr[i, k];
          matr[i, k] = temp;
        }
      }
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

int rows = EnterNumber("введите m: ");
int colums = EnterNumber("введите n: ");
int[,] matrix = new int[rows, colums];
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine($"массив после сортировки: ");
ArrayNumberDecreasing(matrix);
PrintArray(matrix);