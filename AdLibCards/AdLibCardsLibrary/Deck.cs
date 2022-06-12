using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdLibCardsLibrary
{
    public class Deck
    {
        private List<Question_Card> questions; //question cards in the pile
        public List<Question_Card> discardQ = new List<Question_Card>(); //question cards discarded

        private List<Answer_Card> answers;
        public List<Answer_Card> discardA = new List<Answer_Card>();

        //TODO: Consider if List is an efficient data structure to do this 

        public Deck(List<Question_Card> question_cards, List<Answer_Card> answer_cards)
        {
            questions = question_cards;  
            answers = answer_cards;
            
        }

        public void Shuffle(List<Card> cards)
        {
            for (int i = 0; i < (cards.Count - 1); i++)
            {
                //TODO implement shuffle
            }
        }

        public Question_Card DrwQuestion()
        {
            var QCard = questions[^1]; //Last Question_Card in List
            //TODO: shuffle discardQ and append to questions
            questions.RemoveAt(questions.Count - 1);
            discardQ.Add(QCard);
            return QCard;
        }

        public List<Answer_Card> DrwAnswers(int amount)
        {
            var ACards = answers.GetRange(answers.Count - amount - 1, amount);
            for (int i = 0; i < amount; i++)
            {
                answers.Remove(answers[^1]); // Remove Cards from Answer deck
            }
            //TODO: Shuffle discardA and append to answers
            return ACards;
        }

        public Hand GetHand(int size)
        {
            return new Hand(DrwAnswers(size));
        }
    }
}
