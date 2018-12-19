using System;

namespace WarCardGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Card myCard;

            Deck deck = new Deck();
            deck.BuildDeck();
            deck.Shuffle();
            
            myCard = deck.DealCard();
            Console.WriteLine(myCard);
            
            Console.ReadKey();
        }

        private static string CheckResult(Card firstCard, Card secondCard)
        {
            string result = "";

            if (firstCard.Value > secondCard.Value)
            {
                result = $"First Card ({firstCard}) won.";
            }
            else
            {
                result = $"Second Card ({secondCard}) won.";
            }

            return result;
        }
    }
}
