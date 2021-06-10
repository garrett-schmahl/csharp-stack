using System;

namespace _011_iron_ninja
{
  class Program
  {
    static void Main(string[] args)
    {
      Buffet buffet1 = new Buffet();
      Ninja ninjaDave = new SweetTooth();
      Ninja ninjaSam = new SpiceHound();
      while (!ninjaDave.IsFull) { ninjaDave.Consume(buffet1.Serve()); }
      while (!ninjaSam.IsFull) { ninjaSam.Consume(buffet1.Serve()); }
      if (ninjaDave.ConsumptionHistory.Count > ninjaSam.ConsumptionHistory.Count)
      {
        Console.WriteLine("Dave ate the most, he ate " + ninjaDave.ConsumptionHistory.Count + " items.");
      }
      else if (ninjaDave.ConsumptionHistory.Count < ninjaSam.ConsumptionHistory.Count)
      {
        Console.WriteLine("Sam ate the most, he ate " + ninjaSam.ConsumptionHistory.Count + " items.");
      }
      else
      {
        Console.WriteLine("They both ate " + ninjaSam.ConsumptionHistory.Count + " items.");
      }
    }
  }
}
