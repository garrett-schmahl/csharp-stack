using System;
namespace _011_iron_ninja
{
  public class SpiceHound : Ninja
  {
    public override bool IsFull
    {
      get
      {
        if (calorieIntake > 1200)
        {
          return true;
        }
        else
        {
          return false;
        }
      }
    }

    public override void Consume(IConsumable item)
    {
      if (IsFull) { Console.WriteLine("The ninja is too full to eat any more"); }
      else
      {
        calorieIntake += item.Calories;
        if (item.IsSpicy)
        {
          calorieIntake -= 5;
        }
        ConsumptionHistory.Add(item);
        Console.WriteLine(item.GetInfo());
      }
    }
  }
}

