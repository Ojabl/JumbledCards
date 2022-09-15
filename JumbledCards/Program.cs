using System;
using System.Collections.Generic;

namespace JumbledCards
{
    class Program
    {
        private static readonly Random random = new Random();

        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();

            Console.Write("Number of cards: ");

            if(int.TryParse(Console.ReadLine() ,out int numberOfCards))
                for(int i = 0; i < numberOfCards; i++)
                {
                    cards.Add(RandomCard());
                }

            PrintCards(cards);

            cards.Sort(new CardComparerByValue());
            Console.WriteLine("\n\n... sorting the cards ... \n");

            PrintCards(cards);
        }

        static Card RandomCard()
        {
            int randomBetween0and3 = random.Next(4);
            int randomBetween0and13 = random.Next(1, 14);

            Card myCard = new Card((Values)randomBetween0and13, (Suits)randomBetween0and3);

            return myCard;
        }

        static void PrintCards(List<Card> cards)
        {
            foreach(Card card in cards)
            {
                Console.WriteLine(card.Name);
            }
        }
    }
}