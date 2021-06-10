using System;
using System.Collections.Generic;
namespace _011_iron_ninja
{
  public class Buffet
  {
    public List<IConsumable> Menu;

    public Buffet()
    {
      Menu = new List<IConsumable>()
        {
          new Food("Rathalos Burgers and fries", 800, true, false),
          new Food("Black Diablos Tar Tar", 500, false, false),
          new Food("Gos Harag Chunk Ice Cream", 700, false, true),
          new Food("Jyuratodus Fillet with rice", 400, false, false),
          new Food("Hunter's Dango Surprise", 300, true, true),
          new Food("Honey Glazed Azuros Ribs", 600, false, true),
          new Food("Nergigante Shish-kabob", 2500, true, false),
          new Drink("Health Drink", 200, false),
          new Drink("Energy Drink", 300, false),
          new Drink("Dash Juice", 250, false),
          new Drink("Hot Drink", 250, true),
        };
    }

    public IConsumable Serve()
    {
      Random rand = new Random();
      return Menu[rand.Next(Menu.Count)];
    }
  }
}