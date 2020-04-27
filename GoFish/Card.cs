using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFish
{
    class Card
    {
        public Suits Suit { get; set; }
        public Value Value { get; set; }

        public Card(Suits suit, Value value)
        {
            this.Suit = suit;
            this.Value = value;
        }

        public string Name
        {
            get
            {
                return Value.ToString() + " of " + Suit.ToString();
            }
        }
        public override string ToString()
        {
            return Name;
        }

        public static bool DoesCardMatch(Card cardToCheck, Suits suit)
        {
            if (cardToCheck.Suit == suit)
                return true;
            else
                return false;

        }
        public static bool DoesCardMatch(Card cardToCheck, Value value)
        {
            if (cardToCheck.Value == value)
                return true;
            else
                return false;

        }
    }

    enum Suits
    {
        Spades,
        Clubs,
        Dimonds,
        Hearts,
    }

    enum Value
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
        Valet = 11,
        Queen = 12,
        King = 13,
    }
}
