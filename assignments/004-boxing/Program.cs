using System;
using System.Collections.Generic;



namespace _004_boxing
{
  class Program
  {
    static void Main(string[] args)
    {
      List<object> bundle = new List<object>();
      bundle.Add(7);
      bundle.Add(28);
      bundle.Add(-1);
      bundle.Add(true);
      bundle.Add("chair");

      int bundleSum = 0;
      foreach (object item in bundle)
      {
        Console.WriteLine(item);
        if (item is int)
        {
          bundleSum += (int)item;
        }
      }
      Console.WriteLine(bundleSum);
    }
  }
}
