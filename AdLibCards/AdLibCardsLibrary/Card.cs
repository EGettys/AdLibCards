using System.Text.RegularExpressions;

namespace AdLibCardsLibrary
{
    public class Card
    {
        public string text;
        //private int in_deck;
        //private int selected;

        public Card(string card_text)
        {
            text = card_text;
        }
    }

    public class Question_Card : Card
    {
        public byte number_blanks; //number of blanks for answers within expression
        public Question_Card(string card_text) : base(card_text)
        {
            number_blanks = 0;
            // "_" underscore represents blank
            //this.text = Regex.Replace(this.text, "_+", '_'); // Move to display logic 
            Match match_underscore = Regex.Match(this.text, "_+");// Read multiple consecutive underscores as a single blank
            while (match_underscore.Success)
            {
                number_blanks++;
                match_underscore = match_underscore.NextMatch();
            }
        }
    }

    public class Answer_Card : Card
    {
        public Answer_Card(string card_text) : base(card_text)
        { }
    }
}