using System;
namespace _010_wizard_samurai_ninja
{
  class Wizard : Human
  {
    public Wizard(string name) : base(name)
    {
      Health = 60;
      MaxHealth = 60;
      Intelligence = 6;
    }

    public override int Attack(Human target)
    {
      int damage = 5 * Intelligence;
      target.Health -= damage;
      this.Health += damage;
      HealthCheck(this);
      Console.WriteLine("Dealt " + damage + " damage.");
      Console.WriteLine("Healed " + damage + " health.");
      return target.Health;
    }
    public int Heal(Human target)
    {
      int healing = 10 * Intelligence;
      target.Health += healing;
      HealthCheck(target);
      Console.WriteLine("Healed " + healing + " health.");
      return target.Health;
    }
  }
}