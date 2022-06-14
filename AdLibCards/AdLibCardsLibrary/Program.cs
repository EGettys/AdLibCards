using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdLibCardsLibrary
{
    public class Program
    {
        public static readonly string[] answer_strings = new string[] {
            "Corporate America.",
            "Silence.",
            "Website.",
            "Shame.",
            "Magnets.",
            "Complaining.",
            "A positive attitude!",
            "Working in\nan Amazon\nwarehouse.",
            "Being on fire.",
            "Having big dreams\nbut no realistic way\nto achieve them.",
            "Climbing a\ntelephone pole\nand becoming\none with the\nT-Mobile network.",
            "The past.",
            "Science.",
            "Passive-Aggressive\nPost-it notes.",
            "A certain\nje ne sais quoi.",
            "Jobs.",
            "A non-disclosure\nagreement.",
            "Active listening.",
            "Some guy.",
            "The wifi password",
            "Genuine human\nconnection."
        };

        public static readonly string[] question_strings = new string[] {
            "__ + __ = __",
            "Step 1: __.\nStep 2: __.\nStep 3: Profit.",
            "I got 99 problems\nbut __ ain’t one.",
            "__.\nIt's a trap!", "I never truly\nunderstood __\nuntil I encountered\n__.",
            "Uh, hey guys, I\nknow this was my\nidea, but I’m having\nserious doubts\nabout __.",
            "Why can’t I\nsleep at night?",
            "Click Here for\n__!!!",
            "What makes life\nworth living?",
            "But before I kill\nyou, Mr. Bond, I\nmust show you\n__.",
            "This is the way the\nworld ends\nThis is the way the\nworld ends\nNot with a bang but\nwith __.",
            "They said we were\ncrazy. They said we\ncouldn’t put __\ninside of __.\nThey were wrong.",
            "For my next trick, I\nwill pull __\nout of __.",
            "What never fails to\nliven up the party?",
            "Coming to\nBroadway\nthis season,\n__:\nThe Musical.",
            "50% of all\nmarriages end in\n__.", "That’s right, I killed\n__.\nHow, you ask?\n__.",
            "My fellow\nAmericans: Before\nthis decade is\nout, we will have __\non the moon!",
            "__ is a slippery slope\nthat leads to __."
        };
        static void Main()
        {
            List<Question_Card> questions1 = getQuestionCards((string[])question_strings);
            List<Answer_Card> answers1 = getAnswerCards((string[])answer_strings);
            Deck deck1 = new Deck(questions1, answers1);
        }
        public static List<Answer_Card> getAnswerCards(string[] answer_strings)
        {
            List<Answer_Card> answers = new List<Answer_Card>();
            foreach (string answer_text in answer_strings)
            {
                answers.Add(new Answer_Card(answer_text));
            }
            return answers;
        }
        public static List<Question_Card> getQuestionCards(string[] question_strings)
        {
            List<Question_Card> questions = new List<Question_Card>();
            foreach (string question_text in question_strings)
            {
                questions.Add(new Question_Card(question_text));
            }
            return questions;
        }
        //public static void dispCard()
    }
}
