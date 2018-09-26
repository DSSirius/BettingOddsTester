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
    public class GameRunnerTests
    {

        [TestMethod()]
        public void ProfitCalculatesCorrectly()
        {
            // Arrange
            TestBettingMachine testBettingMachine = new TestBettingMachine();
            GameRunner gameRunner = new GameRunner(testBettingMachine);

            // Act
            GameRunnerResult result = gameRunner.RunGamesAndReturnResult(20, 1m);

            // Assert
            Assert.AreEqual(10m, result.ProfitAmount);
        }

        [TestMethod()]
        public void ProfitPercentageCalculatesCorrectly()
        {
            // Arrange
            TestBettingMachine testBettingMachine = new TestBettingMachine();
            GameRunner gameRunner = new GameRunner(testBettingMachine);

            // Act
            GameRunnerResult result = gameRunner.RunGamesAndReturnResult(20, 1m);

            // Assert
            Assert.AreEqual(50, result.ProfitPercentage);
        }


    }
         
        
    class TestBettingMachine : BettingMachine
    {
        public override decimal RunGame(decimal stake, params int[] comparableValues)
        {
            return 0.5m;
        }

        public override int[] GenerateValues()
        {
            int[] result = { 0 };
            return result;
        }
    }
}