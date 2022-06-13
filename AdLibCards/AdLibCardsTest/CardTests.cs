using AdLibCardsLibrary;
namespace AdLibCardsTest
{
    [TestClass]
    public class CardTests
    {
        //Question Card Tests
        [TestMethod]
        public void Question_Card_No_Blank()
        {
            Question_Card qcard = new Question_Card("What makes life worth living?");
            Assert.AreEqual((byte) 0, qcard.number_blanks, "There should be 0 blanks.");
        }
        [TestMethod]
        public void Question_Card_1_Blank()
        {
            Question_Card qcard = new Question_Card("__.It's a trap!");
            Assert.AreEqual((byte)1, qcard.number_blanks, "There should be 1 blank.");
        }
        [TestMethod]
        public void Question_Card_3_Blank()
        {
            Question_Card qcard = new Question_Card("_ + _ = _");
            Assert.AreEqual((byte)3, qcard.number_blanks, "There should be 3 blanks.");
        }
    }
}