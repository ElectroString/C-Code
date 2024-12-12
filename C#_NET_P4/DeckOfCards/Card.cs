/*
 * Cam Davies
 * 8/11/2024
 * Card Class
 */


using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    internal class Card
    {
        private String DEFAULT_SUIT = "Wild";
        private String DEFAULT_RANK = "Wild";
        private String suit;
        private String rank;

        // Default Constructor
        public Card() { 
            this.rank = DEFAULT_RANK;
            this.suit = DEFAULT_SUIT;
        }

        // Parameterized Constructor
        public Card(String suit, String rank)
        {
            this.rank = rank;
            this.suit = suit;
        }

        //Sets / Gets Card Suit
        public String Suit
        {
            get { return this.suit; }
            set { this.suit = value; }
        }

        // Sets / Gets  Card Rank
        public String Rank
        {
            get { return this.rank; }
            set { this.rank = value; }
        }

        // Displays Card Rank and Suit as a string
        public override String ToString()
        {
            return $"{this.rank} - {this.suit}";
        }
    }
}
