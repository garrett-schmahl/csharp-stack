using System;
namespace _010_wizard_samurai_ninja
{
  class Human
  {
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    protected int MaxHealth;
    private int health;
    public int Health
    {
      get { return health; }
      set
      {
        health = value;
      }
    }

    public Human(string name)
    {
      Name = name;
      Strength = 3;
      Intelligence = 3;
      Dexterity = 3;
      health = 100;
      MaxHealth = health;
    }
    public Human(string name, int strength, int intelligence, int dexterity, int health) //overloaded
    {
      Name = name;
      Strength = strength;
      Intelligence = intelligence;
      Dexterity = dexterity;
      Health = health;
      MaxHealth = health;
    }

    public virtual int Attack(Human target)
    {
      int damage = 5 * Strength;
      target.health -= damage;
      Console.WriteLine("Dealt " + damage + " damage.");
      return target.health;
    }
    public void HealthCheck(Human target)
    {
      if (target.Health > target.MaxHealth)
      {
        target.Health = target.MaxHealth;
      }
    }
  }
}