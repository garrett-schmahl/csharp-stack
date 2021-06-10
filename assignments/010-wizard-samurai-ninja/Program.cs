using System;

namespace _010_wizard_samurai_ninja
{
  class Program
  {
    static void Main(string[] args)
    {
      Human regularTodd = new Human("Todd");
      Wizard wizardDresden = new Wizard("Dresden");
      Samurai samuraiJack = new Samurai("Jack");
      Ninja ninjaLuffy = new Ninja("Luffy");

      wizardDresden.Attack(regularTodd);
      Console.WriteLine("Todd has " + regularTodd.Health + " health remaining");
      Console.WriteLine(wizardDresden.Health);
      wizardDresden.Heal(regularTodd);
      Console.WriteLine("Todd has " + regularTodd.Health + " health remaining");
      ninjaLuffy.Attack(regularTodd);
      Console.WriteLine("Todd has " + regularTodd.Health + " health remaining");
      ninjaLuffy.Attack(samuraiJack);
      Console.WriteLine("Jack has " + samuraiJack.Health + " health remaining");
      samuraiJack.Meditate();
      Console.WriteLine("Jack has " + samuraiJack.Health + " health remaining");
      samuraiJack.Attack(regularTodd);
      Console.WriteLine("Todd has " + regularTodd.Health + " health remaining");
      samuraiJack.Attack(regularTodd);
      Console.WriteLine("Todd has " + regularTodd.Health + " health remaining");
      samuraiJack.Attack(regularTodd);
      Console.WriteLine("Todd has " + regularTodd.Health + " health remaining");
    }
  }
}
