using System;
using System.Collections.Generic;

namespace _003_collections_practice
{
  class Program
  {
    static void Main(string[] args)
    {
      //Three Basic Arrays
      int[] oneThruNine = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
      string[] nameArray = { "Tim", "Martin", "Nikki", "Sara" };
      bool[] boolArray = { true, false, true, false, true, false, true, false, true, false };
      //Ice cream manipulation
      List<string> iceCreamFlavors = new List<string>();
      iceCreamFlavors.Add("Vanilla");
      iceCreamFlavors.Add("Chocolate");
      iceCreamFlavors.Add("Strawberry");
      iceCreamFlavors.Add("Cookie Dough");
      iceCreamFlavors.Add("Oreo");

      int flavorCount = iceCreamFlavors.Count;
      Console.WriteLine(flavorCount);

      Console.WriteLine(iceCreamFlavors[2]);
      iceCreamFlavors.RemoveAt(2);

      flavorCount = iceCreamFlavors.Count;
      Console.WriteLine(flavorCount);

      //user info
      Dictionary<string, string> userFlavors = new Dictionary<string, string>();
      Random rand = new Random();
      foreach (string name in nameArray)
      {
        userFlavors.Add(name, iceCreamFlavors[rand.Next(flavorCount)]);
      }

      foreach (KeyValuePair<string, string> user in userFlavors)
      {
        Console.WriteLine(user.Key + " - " + user.Value);
      }
    }
  }
}
