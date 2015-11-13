using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public class Card
    {

        private Suit _suit;
        public Suit suit
        {
            get { return _suit; }
            set { _suit = value; }
        }

        private Face _face;
        public Face face
        {
            get { return _face; }
            set { _face = value; }
        }

        private int _value;
        public int value
        {
            get { return _value; }
            set { _value = value; }
        }

        bool acesAreHigh;

        public Card(Suit suit, Face face, bool acesAreHigh)
        {
            this.suit = suit;
            this.face = face;
            this.acesAreHigh = acesAreHigh;
            this.value = SetCardValue(face, acesAreHigh);         
        }

        public virtual int SetCardValue(Face face, bool acesAreHigh)
        {
            if (face == Face.King || face == Face.Queen || face == Face.Jack)
            {
                return 10;
            }else if(face == Face.Ace && acesAreHigh){
                return 11;
            }            
            return (int)face;            
        }
    }
}
