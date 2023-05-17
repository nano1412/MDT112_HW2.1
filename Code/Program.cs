using System;

class Program{
  static void Main(string[] args)
  {
    int row;
    do
    {
      row = int.Parse(Console.ReadLine());
      if (row >= 0)
      {
        DoPascalTriangle(row);
      }
      else
      {
        Console.WriteLine("Invalid Pascal’s triangle row number.");
      }
    } while (row < 0);
  }

  static void DoPascalTriangle(int row)
  {
    for (int i = 0; i <= row; i++)
    {
      for (int j = 0; j <= i; j++)
      {
        int num = Factorial(i) / (Factorial(j) * Factorial(i - j));
        Console.Write(num + " ");
      }
      Console.WriteLine("");
    }
  }

  static int Factorial(int num)
  {
    if (num <= 1) { return 1; }
    return num * Factorial(num - 1);
  }
}