using System;
namespace _010_wizard_samurai_ninja
{
  class Samurai : Human
  {
    public Samurai(string name) : base(name)
    {
      Health = 200;
      MaxHealth = 200;
    }
    public override int Attack(Human target)
    {
      if (target.Health < 50)
      {
        target.Health = 0;
        Console.WriteLine("Executed.");
      }
      else
      {
        base.Attack(target);
      }
      return target.Health;
    }
    public int Meditate()
    {
      Health = MaxHealth;
      Console.WriteLine("Restored full health.");
      return this.Health;
    }
  }
}