using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Exceptions;
using RockPaperScissors.Model;
using System.Collections.Generic;
using RockPaperScissors.Controller;

namespace RockPaperScissorsTest
{
    [TestClass]
    public class TheGameTest
    {
        #region Part A
        [TestMethod]
        [ExpectedException(typeof(WrongNumberOfPlayersError))]
        public void Error_Wrong_Number_Of_Players_1()
        {
            new Game().rps_game_winner(new List<PlayerGame>()
                                        {
                                            new PlayerGame("Maria","S"),
                                            new PlayerGame("John","R"),
                                            new PlayerGame("Lucy","P")
                                        });
        }

        [TestMethod]
        [ExpectedException(typeof(WrongNumberOfPlayersError))]
        public void Error_Wrong_Number_Of_Players_2()
        {
            new Game().rps_game_winner(new List<PlayerGame>()
                                       {
                                           new PlayerGame("Lucy","P")
                                       });
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchStrategyError))]
        public void Error_No_Such_Strategy_1()
        {
            new Game().rps_game_winner(new List<PlayerGame>()
                                        {
                                            new PlayerGame("Maria","f"),
                                            new PlayerGame("John","S")
                                        });
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchStrategyError))]
        public void Error_No_Such_Strategy_2()
        {
            new Game().rps_game_winner(new List<PlayerGame>()
                                        {
                                            new PlayerGame("Maria","A"),
                                            new PlayerGame("John","R")
                                        });
        }

        [TestMethod]
        public void Players_Same_Move()
        {
            Assert.AreEqual(new Game().rps_game_winner(new List<PlayerGame>() { new PlayerGame("Maria","R"), new PlayerGame("John","R")}).Name, "Maria");
        }

        [TestMethod]
        public void PlayerOne_Winner_Rock()
        {
            Assert.AreEqual(new Game().rps_game_winner(new List<PlayerGame>() { new PlayerGame("Maria", "R"), new PlayerGame("John", "S") }).Name, "Maria");
        }

        [TestMethod]
        public void PlayerOne_Winner_Scissors()
        {
            Assert.AreEqual(new Game().rps_game_winner(new List<PlayerGame>() { new PlayerGame("Maria", "S"), new PlayerGame("John", "P") }).Name, "Maria");
        }

        [TestMethod]
        public void PlayerOne_Winner_Paper()
        {
            Assert.AreEqual(new Game().rps_game_winner(new List<PlayerGame>() { new PlayerGame("Maria", "P"), new PlayerGame("John", "R") }).Name, "Maria");
        }

        [TestMethod]
        public void PlayerTwo_Winner_Rock()
        {
            Assert.AreEqual(new Game().rps_game_winner(new List<PlayerGame>() { new PlayerGame("Maria", "S"), new PlayerGame("John", "R") }).Name, "John");
        }

        [TestMethod]
        public void PlayerTwo_Winner_Scissors()
        {
            Assert.AreEqual(new Game().rps_game_winner(new List<PlayerGame>() { new PlayerGame("Maria", "P"), new PlayerGame("John", "S") }).Name, "John");
        }

        [TestMethod]
        public void PlayerTwo_Winner_Paper()
        {
            Assert.AreEqual(new Game().rps_game_winner(new List<PlayerGame>() { new PlayerGame("Maria", "R"), new PlayerGame("John", "P") }).Name, "John");
        }
        #endregion Part A
    }
}
