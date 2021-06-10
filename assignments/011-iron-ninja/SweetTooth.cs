using System;
namespace _011_iron_ninja
{
  public class SweetTooth : Ninja
  {
    public override bool IsFull
    {
      get
      {
        if (calorieIntake > 1500)
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
        if (item.IsSweet)
        {
          calorieIntake += 10;
        }
        ConsumptionHistory.Add(item);
        Console.WriteLine(item.GetInfo());
      }
    }
  }
}

