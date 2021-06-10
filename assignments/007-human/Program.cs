using System;

namespace _007_human
{
  class Program
  {
    static void Main(string[] args)
    {
      Human humanCharles = new Human("Charles");
      Human humanTodd = new Human("Todd", 5, 5, 5, 150);
      Console.WriteLine("Charles hit Todd. Todd has " + humanCharles.Attack(humanTodd) + " health.");
    }
  }
  public class Human
  {
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexteri[ty;
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
    }
    public Human(string name, int strength, int intelligence, int dexterity, int health) //overloaded
    {
      Name = name;
      Strength = strength;
      Intelligence = intelligence;
      Dexterity = dexterity;
      Health = health;
    }

    public int Attack(Human target)
    {
      int damage = 5 * this.Strength;
      target.Health = target.Health - damage;
      return target.Health;
    }
  }
}
