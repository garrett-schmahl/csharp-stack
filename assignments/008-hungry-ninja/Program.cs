using System;
using System.Collections.Generic;

namespace _008_hungry_ninja
{
  class Program
  {
    static void Main(string[] args)
    {
      Buffet buffet1 = new Buffet();
      Ninja ninjaDave = new Ninja();
      ninjaDave.Eat(buffet1.Serve());
      ninjaDave.Eat(buffet1.Serve());
      ninjaDave.Eat(buffet1.Serve());
      ninjaDave.Eat(buffet1.Serve());
    }
  }

  class Food
  {
    public string Name;
    public int Calories;
    public bool IsSpicy;
    public bool IsSweet;
    public Food(string name, int calories, bool isSpicy, bool isSweet)
    {
      Name = name;
      Calories = calories;
      IsSpicy = isSpicy;
      IsSweet = isSweet;
    }
  }


  class Buffet
  {
    public List<Food> Menu;

    public Buffet()
    {
      Menu = new List<Food>()
        {
          new Food("Rathalos Burgers and fries", 800, true, false),
          new Food("Black Diablos Tar Tar", 500, false, false),
          new Food("Gos Harag Chunk Ice Cream", 700, false, true),
          new Food("Jyuratodus Fillet with rice", 400, false, false),
          new Food("Hunter's Dango Surprise", 300, true, true),
          new Food("Honey Glazed Azuros Ribs", 600, false, true),
          new Food("Nergigante Shish-kabob", 2500, true, false),
        };
    }

    public Food Serve()
    {
      Random rand = new Random();
      return Menu[rand.Next(Menu.Count)];
    }
  }



  class Ninja
  {
    private int calorieIntake;
    public List<Food> FoodHistory;
    public Ninja()
    {
      calorieIntake = 0;
      FoodHistory = new List<Food>();
    }

    public bool IsFull
    {
      get
      {
        if (this.calorieIntake > 1200)
        {
          return true;
        }
        else
        {
          return false;
        }
      }
    }
    public void Eat(Food item)
    {
      if (this.IsFull) { Console.WriteLine("The ninja is too full to eat any more"); }
      else
      {
        this.calorieIntake += item.Calories;
        this.FoodHistory.Add(item);
        Console.Write("The ninja ate the " + item.Name + ". ");
        if (item.IsSpicy) { Console.Write("He found it spicy. "); }
        if (item.IsSweet) { Console.Write("He found it sweet."); }
        Console.WriteLine("");
      }
    }
  }


}
