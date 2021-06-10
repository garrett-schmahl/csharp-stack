using System;
using System.Collections.Generic;
namespace _011_iron_ninja
{
  public abstract class Ninja
  {
    protected int calorieIntake;
    public List<IConsumable> ConsumptionHistory;
    public Ninja()
    {
      calorieIntake = 0;
      ConsumptionHistory = new List<IConsumable>();
    }

    public abstract bool IsFull { get; }
    public abstract void Consume(IConsumable item);
  }
}