//

void FillArray(int[,,] matr)
{
  int[] temp = new int[matr.GetLength(0) * matr.GetLength(1) * matr.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < matr.GetLength(0); x++)
  {
    for (int y = 0; y < matr.GetLength(1); y++)
    {
      for (int z = 0; z < matr.GetLength(2); z++)
      {
        matr[x, y, z] = temp[count];
        count++;
      }
    }
  }
}

void PrintArray(int[,,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      Console.Write($"x({i}) y({j}) ");
      for (int k = 0; k < matr.GetLength(2); k++)
      {
        Console.Write( $"z({k})={matr[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}
int EnterNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int x = EnterNumber("введите x: ");
int y = EnterNumber("введите y: ");
int z = EnterNumber("введите z: ");
int[,,] matrix = new int[x,y,z];
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
