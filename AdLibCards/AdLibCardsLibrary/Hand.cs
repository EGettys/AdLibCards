using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdLibCardsLibrary
{
    public class Hand
    {
        public List<Answer_Card> hand;
        public Hand(List<Answer_Card> cards)
        {
            hand = cards;
        }
        //public List<Answer_Card> playCards(int[] indices)
        //{    hand.Remove() //remove card from hand
            //discardA //add card to discard deck
       // }
        public void displayHand()
        {
            for (int i = 0; i < hand.Count; i++)
            {
                Console.Write(hand);
                Console.Write(i.ToString() + ". ");
                Card card = hand[i];
                Console.WriteLine(card.text);
            }
        }
    }
}
