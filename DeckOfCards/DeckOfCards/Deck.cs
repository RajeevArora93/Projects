using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public class Deck
    {

        Random rd = new Random();

        private List<Card> _listOfCards;
        public List<Card> listOfCards
        {
            get { return _listOfCards; }
            set { _listOfCards = value; }
        }

        public Deck(List<Card> listOfCards)
        {
            this.listOfCards = listOfCards;   
        }

        public Card TakeTopCard()
        {
            Card cardToReturn = listOfCards.First();
            listOfCards.Remove(cardToReturn);
            //listOfCards.Remove(0);
            return cardToReturn;
        }

        public Card TakeRandomCard()
        {
           Card cardToReturn = listOfCards[rd.Next(0, listOfCards.Count)];
           listOfCards.Remove(cardToReturn);
           return cardToReturn;
        }
    }
}
