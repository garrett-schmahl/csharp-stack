using System;

namespace _005_basic13
{
  class Program
  {
    static void Main(string[] args)
    {
      PrintNumbers();
      PrintOdds();
      PrintSum();
      int[] testArray = { 1, 2, 3, 4, 5 };
      LoopArray(testArray);
      FindMax(testArray);
      GetAverage(testArray);
      foreach (int val in OddArray())
      {
        Console.Write(val + " ");
      }
      Console.WriteLine(GreaterThanY(testArray, 3));
      SquareArrayValues(testArray);
      foreach (int val in testArray)
      {
        Console.WriteLine(val);
      }
      MinMaxAverage(testArray);


      int[] testArray2 = { 1, 2, 3, 4, 5, -1, 0 };
      foreach (object val in NumToString(testArray2))
      {
        Console.Write(val + " ");
      }

    }
    public static void PrintNumbers()
    {
      int i = 1;
      while (i <= 255)
      {
        Console.WriteLine(i);
        i += 1;
      }
    }
    public static void PrintOdds()
    {
      int i = 1;
      while (i <= 255)
      {
        Console.WriteLine(i);
        i += 2;
      }
    }
    public static void PrintSum()
    {
      int i = 1;
      int sum = 0;
      while (i <= 255)
      {
        sum += i;
        Console.WriteLine("New number: " + i + " Sum: " + sum);
        i += 1;
      }
    }
    public static void LoopArray(int[] numbers)
    {
      foreach (int val in numbers)
      {
        Console.WriteLine(val);
      }
    }
    public static int FindMax(int[] numbers)
    {
      int max = 0;
      foreach (int val in numbers)
      {
        if (val > max)
        {
          max = val;
        }
      }
      Console.WriteLine("max " + max);
      return max;
    }
    public static void GetAverage(int[] numbers)
    {
      int sum = 0;
      foreach (int val in numbers)
      {
        sum += val;
      }
      short average = (short)(sum / numbers.Length);
      Console.WriteLine("average " + average);
    }

    public static int[] OddArray()
    {
      int totalOdds = 255 / 2 + 1;
      int[] oddArray = new int[totalOdds];
      int i = 1;
      int oddArrayIndex = 0;
      while (i <= 255)
      {
        oddArray[oddArrayIndex] = i;
        oddArrayIndex++;
        i += 2;
      }
      return oddArray;
    }
    public static int GreaterThanY(int[] numbers, int y)
    {
      int greaterCount = 0;
      foreach (int val in numbers)
      {
        if (val > y)
        {
          greaterCount += 1;
        }
      }
      return greaterCount;
    }
    public static void SquareArrayValues(int[] numbers)
    {
      for (int i = 0; i < numbers.Length; i++)
      {
        numbers[i] = numbers[i] * numbers[i];
      }
    }
    public static void EliminateNegatives(int[] numbers)
    {
      for (int i = 0; i < numbers.Length; i++)
      {
        if (numbers[i] < 0)
        {
          numbers[i] = 0;
        }
      }
    }
    public static void MinMaxAverage(int[] numbers)
    {
      int min = numbers[0];
      int max = 0;
      int sum = 0;
      foreach (int val in numbers)
      {
        sum += val;
        if (val < min)
        {
          min = val;
        }
        else if (val > max)
        {
          max = val;
        }
      }
      short avg = (short)(max / numbers.Length);
      Console.WriteLine("Min: " + min + " Max: " + max + " Average: " + avg);
    }
    public static void ShiftValues(int[] numbers)
    {
      for (int i = 0; i < numbers.Length - 1; i++)
      {
        numbers[i] = numbers[i + 1];
      }
      numbers[numbers.Length] = 0;
    }
    public static object[] NumToString(int[] numbers)
    {
      object[] strArray = new object[numbers.Length];
      int strArrayIndex = 0;
      foreach (int val in numbers)
      {
        if (val < 0)
        {
          strArray[strArrayIndex] = "Dojo";
        }
        else
        {
          strArray[strArrayIndex] = val;
        }
        strArrayIndex += 1;
      }
      return strArray;
    }
  }
}
