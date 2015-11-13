using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeckOfCards;
using Moq;
using System.Collections.Generic;

namespace DeckOfCardsTest
{
    [TestClass]
    public class DeckTest
    {
        [TestMethod]
        public void Test_Constructor_SetsFiftyTwoCardsInAList()
        {
            //Arrange
            int expected = 52;
            Mock<DeckGenerator> mockGenerateDeck = new Mock<DeckGenerator>();

            //Act
            Deck testDeck = new Deck(mockGenerateDeck.Object.GenerateDeck());

            //Assert
            Assert.AreEqual(expected, testDeck.listOfCards.Count);
        }

        //[TestMethod]
        //public void Test_Constructor_SetsFiftyTwoUniqueCardsInAList()
        //{
        //    //Arrange
        //    bool expected = true;

        //    //Act
        //    Deck testDeck = new Deck();

        //    //Assert
        //    Assert.IsTrue(testDeck.listOfCards.Distinct().Count() == 52); 
        //}

        [TestMethod]
        public void Test_TakeTopCard_ReturnsFirstCardAndRemovesItFromTheDeck()
        {
            //Arrange            
            Mock<DeckGenerator> mockGenerateDeck = new Mock<DeckGenerator>();
            Deck testDeck = new Deck(mockGenerateDeck.Object.GenerateDeck());
            Card expectedCard = testDeck.listOfCards.First();
            int expectedNumber = 51;

            //Act
            Card returnedCard = testDeck.TakeTopCard();

            //Assert
            Assert.AreEqual(expectedCard, returnedCard);
            Assert.AreEqual(expectedNumber, testDeck.listOfCards.Count);
        }

        [TestMethod]
        public void Test_TakeRandomCard_ReturnsACardAndRemovesItFromTheDeck()
        {
            //Arrange            
            Mock<DeckGenerator> mockGenerateDeck = new Mock<DeckGenerator>();
            Deck testDeck = new Deck(mockGenerateDeck.Object.GenerateDeck());
            int expectedNumber = 51;

            //Act
            Card returnedCard = testDeck.TakeRandomCard();

            //Assert
            Assert.IsInstanceOfType(returnedCard, typeof(Card));
        }
    }
}
