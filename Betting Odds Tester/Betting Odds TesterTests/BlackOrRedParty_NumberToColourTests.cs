using Microsoft.VisualStudio.TestTools.UnitTesting;
using Betting_Odds_Tester;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Betting_Odds_Tester.Tests
{
    [TestClass()]
    public class BlackOrRedParty_NumberToColourTests
    {
        [TestMethod()]
        public void Number30ReturnsBlack()
        {
            // Arrange
            BlackOrRedParty_NumberToColour numberToColour = new BlackOrRedParty_NumberToColour();

            // Act
            int result = numberToColour.ConvertRandomNumberToGameColour(30);

            // Assert
            Assert.AreEqual((int)RouletteColour.black, result);
        }

        [TestMethod()]
        public void Number31ReturnsRed()
        {
            // Arrange
            BlackOrRedParty_NumberToColour numberToColour = new BlackOrRedParty_NumberToColour();

            // Act
            int result = numberToColour.ConvertRandomNumberToGameColour(31);

            // assert
            Assert.AreEqual((int)RouletteColour.red, result);
        }

        [TestMethod()]
        public void Number61ReturnsWhite()
        {
            // Arrange
            BlackOrRedParty_NumberToColour numberToColour = new BlackOrRedParty_NumberToColour();

            // Act
            int result = numberToColour.ConvertRandomNumberToGameColour(61);

            // assert
            Assert.AreEqual((int)RouletteColour.white, result);
        }
    }
}