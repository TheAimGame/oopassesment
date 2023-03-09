using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        private int value;

        public int Value 
        { 
            get { return value; }
            set 
            { 
                if (value >= 1 && value <= 13)
                {
                    value = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Value must be between 1 and 13");
                }
            }
        }

        private int suit;

        public int Suit
        {
            get { return suit; }
            set 
            { 
                if (value >= 1 && value <= 4)
                {
                    suit = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Suit must be between 1 and 4");
                }
            }
        }

        public Card(int value, int suit)
        {
            this.value = value;
            this.suit = suit;
        }
    }
}

