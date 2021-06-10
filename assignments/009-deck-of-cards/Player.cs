using System.Collections.Generic;
using System;
namespace _009_deck_of_cards
{
  class Player
  {
    string Name;
    public List<Card> Hand;
    public Player(string name)
    {
      Name = name;
      Hand = new List<Card>();
    }
    public void Draw(Deck deck)
    {
      Hand.Add(deck.Deal());
    }

    public Card Discard(int index)
    {
      if (index <= Hand.Count)
      {
        Card discardSelection = Hand[index];
        Hand.RemoveAt(index);
        return discardSelection;
      }
      else
      {
        Console.WriteLine("Player does not have that many cards.");
        return null;
      }
    }
  }
}