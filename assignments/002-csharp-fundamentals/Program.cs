using System;

namespace csharp_fundamentals
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("1. Create a loop that prints all values from 1-255");
      for (int i = 0; i <= 255; i++)
      {
        Console.WriteLine(i);
      }

      Console.WriteLine("2. Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both.");
      for (int i = 0; i <= 100; i++)
      {
        if (i % 3 == 0 && i % 5 == 0)
        {
          continue;
        }
        else if (i % 3 == 0 || i % 5 == 0)
        {
          Console.WriteLine(i);
        }
      }

      Console.WriteLine("3. Modify the previous function to print 'Fizz' for multiples of 3 and 'Buzz' for multiples of 5, and 'FizzBuzz' for multiples of both.");
      for (int i = 0; i <= 100; i++)
      {
        if (i % 3 == 0 && i % 5 == 0)
        {
          Console.WriteLine(i + "FizzBuzz");
        }
        else
        {
          if (i % 3 == 0)
          {
            Console.WriteLine(i + "Fizz");
          }
          else if (i % 5 == 0)
          {
            Console.WriteLine(i + "Buzz");
          }
        }
      }
    }
  }
}