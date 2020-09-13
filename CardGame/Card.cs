using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Card
    {


        public enum CardName
        {

            Ace = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 11,
            Queen = 12,
            King = 13

        }

        public CardName cardName;

        
        public enum CardSuite
        {
            Hearts = 1,
            Diamonds = 2,
            Clubs = 3,
            Spades = 4
        };

        public CardSuite cardSuite;

        public Card(int cardName, int cardSuite)
        {
            this.cardName = (CardName)cardName;
            this.cardSuite = (CardSuite)cardSuite;

        }
    }
}
