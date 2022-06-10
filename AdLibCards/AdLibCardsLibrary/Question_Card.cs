using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdLibCardsLibrary
{
    public class Question_Card : Card
    {
        public byte number_blanks; //number of blanks for answers within expression
        public Question_Card(string card_text) : base(card_text)
        {
            number_blanks = 0; 
            // "_" underscore represents blank
            Match match_underscore = Regex.Match(this.text, "_+");// Read multiple consecutive underscores as a single blank
            while (match_underscore.Success)
            {
                //TODO: Consider adding to convert multiple underscores
                // to single underscore for consistency with display logic

                number_blanks++;
            }

        }
    }
}
