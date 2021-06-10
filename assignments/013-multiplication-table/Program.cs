using System;

namespace _013_multiplication_table
{
  class Program
  {
    static void Main(string[] args)
    {
      int[,] multiplicationTable = new int[10, 10];

      //creating table
      for (int i = 0; i < 10; i++)
      {
        for (int j = 0; j < 10; j++)
        {
          multiplicationTable[i, j] = (i + 1) * (j + 1);
        }
      }

    }
  }
}
