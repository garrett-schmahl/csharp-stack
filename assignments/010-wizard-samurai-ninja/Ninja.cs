using System;
namespace _010_wizard_samurai_ninja
{
  class Ninja : Human
  {
    public Ninja(string name) : base(name)
    {
      Dexterity = 5;
    }
    public override int Attack(Human target)
    {
      Random rand = new Random();
      int damage = 5 * Dexterity;
      if (rand.Next(5) == 0)
      {
        damage += 10;
        Console.WriteLine("Critical Hit!");
      }
      target.Health -= damage;
      Console.WriteLine("Dealt " + damage + " damage.");
      return target.Health;
    }
    public int Steal(Human target)
    {
      target.Health -= 5;
      this.Health += 5;
      HealthCheck(this);
      Console.WriteLine("Stole 5 Health");
      return target.Health;
    }
  }
}