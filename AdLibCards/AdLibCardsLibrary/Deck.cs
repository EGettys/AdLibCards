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

        private Random rand = new Random();

        public Deck(List<Question_Card> question_cards, List<Answer_Card> answer_cards)
        {
            questions = question_cards;  
            answers = answer_cards;
        }

        public void Shuffle<T>(List<T> cards)
        {
            // Fisher-Yates/Durstenfield Algorithm 
            // https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle
            for (int i = 0; i < (cards.Count - 1); i++)
            {
                int sIndex = rand.Next(i, cards.Count);
                (cards[i], cards[sIndex]) = (cards[sIndex], cards[i]);//tuple swap
                // reference https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/style-rules/ide0180
            }
        }

        public Question_Card DrwQuestion()
        {
            if(questions.Count < 1) { //Shuffle discard & append
                Shuffle(discardQ);
                questions.AddRange(discardQ);
                discardQ.Clear();
            }
            var QCard = questions[^1]; //Last Question_Card in List
            questions.RemoveAt(questions.Count - 1);
            discardQ.Add(QCard);
            return QCard;
        }

        public List<Answer_Card> DrwAnswers(int amount)
        {
            if (answers.Count < amount)
            { //Shuffle discard & append
                Shuffle(discardA);
                answers.AddRange(discardA);
                discardA.Clear();
            }
            var indexA = answers.Count - 1 - amount;
            var ACards = answers.GetRange(indexA, amount);
            answers.RemoveRange(indexA, amount); // Remove Cards from Answer deck
            //TODO: card collection type to deduplicate between answer & question
            return ACards;
        }

        public Hand GetHand(int size)
        {
            return new Hand(DrwAnswers(size));
        }

        public void DiscardAnswers(List<Answer_Card> cardsPlayed)
        {
            foreach (Answer_Card card in cardsPlayed)
                {
                    discardA.Add(card);
                }
        }

        public void Display()
        {
            Console.WriteLine("Question Cards");
            for (int i = 0; i < questions.Count; i++)
            {
                Console.Write(i.ToString() + ". ");
                Card card = questions[i];
                Console.WriteLine(card.text);
            }
            Console.WriteLine("Answer Cards");
            for (int j = 0; j < answers.Count; j++)
            {
                Console.Write(j.ToString() + ". ");
                Card card = answers[j];
                Console.WriteLine(card.text);
            }
        }
    }
}
