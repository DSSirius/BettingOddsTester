using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Betting_Odds_Tester.Tests
{
    [TestClass()]
    public class BlackOrRedPartyTests
    {
        [TestMethod()]
        public void PlayersWinWhenTheirColourIsCorrect()
        {
            // Arrange
            int[] rouletteColours = { (int)RouletteColour.black, (int)RouletteColour.black };
            BlackOrRedParty blackOrRedParty = new BlackOrRedParty();
            decimal stake = 1m;

            // Act
            decimal result = blackOrRedParty.RunGame(stake, rouletteColours);

            // Assert 
            Assert.AreEqual(2m, result);
        }

        [TestMethod()]
        public void PlayerLosesWhenTheirColourIsWrong()
        {
            // Arrange
            int[] rouletteColours = { (int)RouletteColour.black, (int)RouletteColour.red };
            BlackOrRedParty blackOrRedParty = new BlackOrRedParty();
            decimal stake = 1m;

            // Act
            decimal result = blackOrRedParty.RunGame(stake, rouletteColours);

            // Assert 
            Assert.AreEqual(0m, result);
        }

        [TestMethod()]
        public void PlayerGets10PercentWhenWhiteIsLanded()
        {
            // Arrange
            int[] rouletteColours = { (int)RouletteColour.black, (int)RouletteColour.white };
            BlackOrRedParty blackOrRedParty = new BlackOrRedParty();
            decimal stake = 1m;

            // Act
            decimal result = blackOrRedParty.RunGame(stake, rouletteColours);

            // Assert 
            Assert.AreEqual(0.1m, result);
        }

    }
}