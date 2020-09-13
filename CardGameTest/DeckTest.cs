using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardGame;




namespace CardGameTest
{
    
    [TestClass]
    public class DeckTest
    {
        Deck deck = new Deck();
        [TestMethod]
        public void Deck_InitializeDeckList()
        {            
            Assert.IsTrue(deck.InitializeDeck());           
        }

        [TestMethod]
        public void Deck_PullFromDeck()
        {
            Assert.IsTrue(deck.Pull());
        }
        [TestMethod]
        public void Deck_SortDeckList()
        {
            Assert.IsTrue(deck.Sort());
        }
        [TestMethod]
        public void Deck_ShuffleDeckList()
        {
            Assert.IsTrue(deck.Shuffle());
        }
    }
}
