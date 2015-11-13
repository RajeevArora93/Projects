using DeckOfCards;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCardsTest
{
    [TestClass]
    public class CardTest
    {
        Face testFace;
        Suit testSuit;
        Card testCard;
        int expectedValue;
        int actualValue;

        [TestMethod]
        public void Test_Constructor_SetsASuitOnTheCard_WhenGivenASuit() 
        {
            //Arrange
            testSuit = Suit.Diamonds;

            //Act
            testCard = new Card(testSuit, Face.Ace , false);
        
            //Assert
            Assert.AreEqual(Suit.Diamonds, testCard.suit);
        }

        [TestMethod]
        public void Test_Constructor_SetsAFaceOnTheCard_WhenGivenAFace() 
        { 
            //Arrange
            testFace = Face.Jack;

            //Act
            testCard = new Card(Suit.Hearts, testFace, false);
            
            //Assert
            Assert.AreEqual(testFace, testCard.face);

        }

        [TestMethod]
        public void Test_SetCardValue_SetsAValueOnTheCard_WhenGivenANumberFace()
        {
            //Arrange
            testFace = Face.Eight;
            expectedValue = 8;

            //Act
            Card testCard = new Card(Suit.Diamonds, testFace, false);

            //Assert
            Assert.AreEqual(expectedValue, testCard.value);
        }

        [TestMethod]
        public void Test_SetCardValue_SetsTheValueToTen_WhenGivenAKingCard()
        {
            //Arrange
            testCard = new Card(Suit.Hearts, Face.King, false);
            testFace = Face.King;
            expectedValue = 10;

            //Act
            actualValue = testCard.SetCardValue(testFace, false);

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void Test_SetCardValue_SetsTheValueToTen_WhenGivenAQueenCard()
        {

            //Arrange
            testCard = new Card(Suit.Hearts, Face.Queen, false);
            testFace = Face.Queen;
            expectedValue = 10;
            //Act
            actualValue = testCard.SetCardValue(testFace, false);

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void Test_SetCardValue_SetsTheValueToTen_WhenGivenAJackCard()
        {
            //Arrange
            testCard = new Card(Suit.Hearts, Face.Jack, false);
            testFace = Face.Jack;
            expectedValue = 10;

            //Act
            actualValue = testCard.SetCardValue(testFace, false);

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void Test_Constructor_CallsSetCardValueOnce_WhenGivenAFaceAndSuit()
        {
            //Arrange
            Mock<Card> mockCard = new Mock<Card>(Suit.Hearts, Face.King, false);
           // mockCard.Setup(x => x.SetCardValue(It.IsAny<Face>()));

            //Act
            testCard = mockCard.Object;

            //Assert
            mockCard.Verify(x => x.SetCardValue(It.IsAny<Face>(), It.IsAny<bool>()), Times.Once);
        }

        [TestMethod]
        public void Test_SetCardValue_SetsValueOfToEleven_WhenGivenAnAceAndAcesAreHigh() 
        { 
            //Arrange
            testCard = new Card(Suit.Spades, Face.Ace, false);
            testFace = Face.Ace;            
            bool acesAreHigh = true;
            expectedValue = 11;

            //Act
            actualValue = testCard.SetCardValue(testFace, acesAreHigh);
            
            //Assert
            Assert.AreEqual(expectedValue, actualValue);

        }

    }
}
