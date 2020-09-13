using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardGame;

namespace TestCardGame
{
    [TestClass]
    public class UnitTest1
    {
        Deck deck = new Deck();
        
        [TestMethod]
        public void TestDeckPull()
        {
            Assert.IsTrue(deck.Pull());
        }

        [TestMethod]
        public void TestInitializeDeck()
        {
            Assert.IsTrue(deck.InitializeDeck());
        }

        [TestMethod]
        public void TestSortDeck()
        {
            Assert.IsTrue(deck.Sort());
        }

        [TestMethod]
        public void TestShuffleDeck()
        {
            Assert.IsTrue(deck.Shuffle());
        }
    }
}
