using System;

namespace _009_deck_of_cards
{
  class Program
  {
    static void Main(string[] args)
    {
      Deck testDeck = new Deck();
      testDeck.Shuffle();
      testDeck.initialize();
      testDeck.Shuffle();

      Player playerTodd = new Player("Todd");

      playerTodd.Draw(testDeck);
      playerTodd.Draw(testDeck);
      playerTodd.Draw(testDeck);
      playerTodd.Draw(testDeck);
      playerTodd.Draw(testDeck);
      foreach (Card card in playerTodd.Hand)
      {
        Console.WriteLine(card.StringVal + " of " + card.Suit);
      }
      Console.WriteLine(playerTodd.Discard(1).StringVal);
      playerTodd.Discard(7);

      // Console.WriteLine("Your card is " + testDeck.Deal().StringVal + " of " + testDeck.Deal().Suit);
      // foreach (Card card in testDeck.Cards)
      // {
      //   Console.WriteLine(card.StringVal + " of " + card.Suit);
      // }
    }
  }
}
