/*
 * Cam Davies
 * 8/11/2024
 * Deck Class
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    internal class Deck
    {
        
        List<Card> cards = new List<Card> { };
        // Initializes a standard deck of Cards
        public Deck() {
            List<Card> tempCards = new List<Card> {
                new Card("Hearts","Ace"),
                new Card("Hearts", "2"),
                new Card("Hearts", "3"),
                new Card("Hearts", "4"),
                new Card("Hearts", "5"),
                new Card("Hearts", "6"),
                new Card("Hearts", "7"),
                new Card("Hearts", "8"),
                new Card("Hearts", "9"),
                new Card("Hearts", "10"),
                new Card("Hearts", "Jack"),
                new Card("Hearts", "Queen"),
                new Card("Hearts", "King"),

                new Card("Diamonds", "Ace"),
                new Card("Diamonds", "2"),
                new Card("Diamonds", "3"),
                new Card("Diamonds", "4"),
                new Card("Diamonds", "5"),
                new Card("Diamonds", "6"),
                new Card("Diamonds", "7"),
                new Card("Diamonds", "8"),
                new Card("Diamonds", "9"),
                new Card("Diamonds", "10"),
                new Card("Diamonds", "Jack"),
                new Card("Diamonds", "Queen"),
                new Card("Diamonds", "King"),

                new Card("Spades", "Ace"),
                new Card("Spades", "2"),
                new Card("Spades", "3"),
                new Card("Spades", "4"),
                new Card("Spades", "5"),
                new Card("Spades", "6"),
                new Card("Spades", "7"),
                new Card("Spades", "8"),
                new Card("Spades", "9"),
                new Card("Spades", "10"),
                new Card("Spades", "Jack"),
                new Card("Spades", "Queen"),
                new Card("Spades", "King"),

                new Card("Clubs", "Ace"),
                new Card("Clubs", "2"),
                new Card("Clubs", "3"),
                new Card("Clubs", "4"),
                new Card("Clubs", "5"),
                new Card("Clubs", "6"),
                new Card("Clubs", "7"),
                new Card("Clubs", "8"),
                new Card("Clubs", "9"),
                new Card("Clubs", "10"),
                new Card("Clubs", "Jack"),
                new Card("Clubs", "Queen"),
                new Card("Clubs", "King")};

            this.cards = tempCards.ToList();
        }

       // Gets/ Sets Cards list
        public List<Card> Cards {
            get
            {
                return this.cards;
            }
            set
            {
                this.cards = value;
            }
                 
        
        }

   
    }
}
