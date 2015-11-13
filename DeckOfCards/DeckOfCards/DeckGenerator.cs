using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public class DeckGenerator
    {
        public List<Card> GenerateDeck() 
        {
            List<Card> listOfCards = new List<Card>();

            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            { 
                foreach (Face face in Enum.GetValues(typeof(Face))) 
                {
                    listOfCards.Add(new Card(suit, face, false));
                }
            }

            //foreach(Card c in listOfCards)
            //{
            //    Console.WriteLine("Suit: " + c.suit + " | Face: " + c.face + " | value: " + c.value );
            //}

            return listOfCards;
        }
    }
}
