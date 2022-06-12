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
    }
}
