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
    public class DiceRoll2000Tests
    {
        [TestMethod()]
        public void PlayersWinWhenTheyRollADouble()
        {
            // Arrange
            int[] diceRolls = { 1, 1};
            DiceRoll2000 diceRoll2000 = new DiceRoll2000();
            decimal stake = 1m;

            // Act
            decimal result = diceRoll2000.RunGame(stake, diceRolls);

            // Assert 
            Assert.AreEqual(1.5m, result);
        }


        [TestMethod()]
        public void PlayersLoseWhenTheyFailARoll()
        {
            // Arrange
            int[] diceRolls = { 1, 2 };
            DiceRoll2000 diceRoll2000 = new DiceRoll2000();
            decimal stake = 1m;

            // Act
            decimal result = diceRoll2000.RunGame(stake, diceRolls);

            // Assert 
            Assert.AreEqual(0m, result);
        }

        [TestMethod()]
        public void WinMultiplierWorksCorrectly()
        {
            // Arrange
            int[] diceRolls = { 6, 6 };
            DiceRoll2000 diceRoll2000 = new DiceRoll2000();
            decimal stake = 1m;

            // Act
            decimal result = diceRoll2000.RunGame(stake, diceRolls);

            // Assert 
            Assert.AreEqual(9m, result);
        }

    }
}