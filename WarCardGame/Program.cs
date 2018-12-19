using System;

namespace WarCardGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Card myCard, computerCard;

            Deck deck = new Deck();
            deck.BuildDeck();

            myCard = deck.DealCard();
            Console.WriteLine("Your card:");
            Console.WriteLine(myCard);

            computerCard = deck.DealCard();
            Console.WriteLine("\nComputer's card:");
            Console.WriteLine(computerCard);

            var result = Program.CheckResult(myCard, computerCard);
            Console.WriteLine($"\nResult: {result}");

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
