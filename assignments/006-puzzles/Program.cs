using System;
using System.Collections.Generic;

namespace _006puzzles
{
  class Program
  {
    static void Main(string[] args)
    {
      ParseRandomArray(RandomArray());
      Console.WriteLine(TossMultipleCoins(5));
      foreach (string name in ShuffleNames(Names()))
      {
        Console.WriteLine(name);
      };
      foreach (string name in FuckTodd(Names()))
      {
        Console.WriteLine(name);
      }
    }
    public static int[] RandomArray()
    {
      Random rand = new Random();
      int[] newArray = new int[10];
      for (int i = 0; i < newArray.Length; i++)
      {
        newArray[i] = rand.Next(5, 26);
      }
      return newArray;
    }
    public static void ParseRandomArray(int[] numbers)
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
      Console.WriteLine("Min: " + min);
      Console.WriteLine("Max: " + max);
      Console.WriteLine("Sum: " + sum);
    }

    public static string TossCoin()
    {
      Console.WriteLine("Tossing a coin...");
      Random rand = new Random();
      int flip = rand.Next(2);
      string results = "heads";
      if (flip == 0)
      {
        results = "tails";
      }
      Console.WriteLine(results);
      return results;
    }
    public static double TossMultipleCoins(int tossCount)
    {
      int headCount = 0;
      string[] resultsArray = new string[tossCount];
      for (int i = 0; i < tossCount; i++)
      {
        resultsArray[i] = TossCoin();
      }
      foreach (string val in resultsArray)
      {
        if (val == "heads")
        {
          headCount++;
        }
      }
      double resultRatio = (double)headCount / tossCount;
      return resultRatio;
    }
    public static List<string> Names()
    {
      List<string> names = new List<string>();
      names.Add("Todd");
      names.Add("Tiffany");
      names.Add("Charlie");
      names.Add("Geneva");
      names.Add("Sydney");
      return names;
    }
    public static List<string> ShuffleNames(List<string> names)
    {
      Random rand = new Random();
      int totalNames = names.Count;
      string nameSaver = "";
      for (int i = 0; i < totalNames; i++)
      {
        nameSaver = names[i];
        names.RemoveAt(i);
        names.Insert(rand.Next(totalNames), nameSaver);
      }
      return names;
    }
    public static List<string> FuckTodd(List<string> names)
    {
      List<string> filteredNames = new List<string>();
      foreach (string name in names)
      {
        if (name.Length >= 5)
        {
          filteredNames.Add(name);
        }
      }
      return filteredNames;
    }
  }
}
