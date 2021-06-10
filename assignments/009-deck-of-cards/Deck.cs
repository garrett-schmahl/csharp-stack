using System;
using System.Collections.Generic;
namespace _009_deck_of_cards
{
  class Deck
  {
    public List<Card> Cards;

    public Deck()
    {
      Cards = new List<Card>();
      initialize();
    }

    public void Shuffle()
    {
      Random rand = new Random();
      for (int i = 0; i < 100; i++)
      {
        int SwapIndex = rand.Next(Cards.Count - 1);
        Card holdingCard = Cards[SwapIndex];
        Cards.RemoveAt(SwapIndex);
        Cards.Add(holdingCard);
      }
    }
    public Card Deal()
    {
      if (Cards.Count > 0)
      {
        Card deltCard = Cards[0];
        Cards.RemoveAt(0);
        return deltCard;
      }
      else
      {
        Console.WriteLine("No cards left to deal.");
        return null;
      }
    }
    public void initialize()
    {
      Cards.Clear();
      int[] cardValues = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
      string[] cardStrings = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
      string[] cardSuits = { "Hearts", "Diamonds", "Clubs", "Spades" };
      foreach (string suit in cardSuits)
      {
        for (int i = 0; i < cardValues.Length; i++)
        {
          Cards.Add(new Card(cardStrings[i], suit, cardValues[i]));
        }
      }
    }
  }
}