using AdLibCardsLibrary;

namespace AdLibCardsTest
{
    [TestClass]
    public class DeckTests
    {
        List<Question_Card> questions1 = Program.getQuestionCards(Program.question_strings);
        List<Answer_Card> answers1 = Program.getAnswerCards(Program.answer_strings);
        Deck deck1;

        [TestInitialize]
        public void intit()
        {
            deck1 = new Deck(questions1, answers1);
        }

        [TestMethod]
        public void DrawnQCard()
        {
            var expected = new Question_Card(Program.question_strings[Program.question_strings.Length - 1]);
            expected.displayCard();
            var actual = deck1.DrwQuestion();
            actual.displayCard();
            Assert.AreEqual(expected, actual, "The card should be drawn from the end of the deck.");
        }
        [TestMethod]
        public void DiscardQCard()
        {
            deck1.DrwQuestion();
            Assert.AreEqual(1,deck1.discardQ.Count, "There should be only 1 card in the discard pile");
        }
        [TestMethod]
        public void GetHand5()
        {
           // desk1.getHand()
            //Assert.AreEqual(new Answer_Card(Program.answer_strings[Program.answer_strings-1]))
        }
    }
}