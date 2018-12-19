using System;

namespace WarCardGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Card card;
            Deck deck = new Deck();
            deck.BuildDeck();

            deck.Shuffle();

            card = deck.DealCard();
            Console.WriteLine(card);
            card = deck.DealCard();
            Console.WriteLine(card);
            card = deck.DealCard();
            Console.WriteLine(card);
            card = deck.DealCard();
            Console.WriteLine(card);

            Console.ReadKey();
        }
    }
}
