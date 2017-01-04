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
            var game = new Game(new List<PlayerGame>()
                       {
                           new PlayerGame("Maria","S"),
                           new PlayerGame("John","R"),
                           new PlayerGame("Lucy","P")
                       });

            game.rps_game_winner();
        }

        [TestMethod]
        [ExpectedException(typeof(WrongNumberOfPlayersError))]
        public void Error_Wrong_Number_Of_Players_2()
        {
            var game = new Game(new List<PlayerGame>()
                       {
                           new PlayerGame("Lucy","P")
                       });

            game.rps_game_winner();
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchStrategyError))]
        public void Error_No_Such_Strategy_1()
        {
            var game = new Game(new List<PlayerGame>()
                       {
                           new PlayerGame("Maria","f"),
                           new PlayerGame("John","S")
                       });

            game.rps_game_winner();
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchStrategyError))]
        public void Error_No_Such_Strategy_2()
        {
            var game = new Game(new List<PlayerGame>()
                       {
                           new PlayerGame("Maria","A"),
                           new PlayerGame("John","R")
                       });

            game.rps_game_winner();
        }

        [TestMethod]
        public void Players_Same_Move()
        {
            var game = new Game(new List<PlayerGame>()
                       {
                           new PlayerGame("Maria","R"),
                           new PlayerGame("John","R")
                       });

            Assert.AreEqual(game.rps_game_winner().Name, "Maria");
        }

        [TestMethod]
        public void PlayerOne_Winner_Rock()
        {
            var game = new Game(new List<PlayerGame>()
                       {
                           new PlayerGame("Maria","R"),
                           new PlayerGame("John","S")
                       });

            Assert.AreEqual(game.rps_game_winner().Name, "Maria");
        }

        [TestMethod]
        public void PlayerOne_Winner_Scissors()
        {
            var game = new Game(new List<PlayerGame>()
                       {
                           new PlayerGame("Maria","S"),
                           new PlayerGame("John","P")
                       });

            Assert.AreEqual(game.rps_game_winner().Name, "Maria");
        }

        [TestMethod]
        public void PlayerOne_Winner_Paper()
        {
            var game = new Game(new List<PlayerGame>()
                       {
                           new PlayerGame("Maria","P"),
                           new PlayerGame("John","R")
                       });

            Assert.AreEqual(game.rps_game_winner().Name, "Maria");
        }

        [TestMethod]
        public void PlayerTwo_Winner_Rock()
        {
            var game = new Game(new List<PlayerGame>()
                       {
                           new PlayerGame("Maria","S"),
                           new PlayerGame("John","R")
                       });

            Assert.AreEqual(game.rps_game_winner().Name, "John");
        }

        [TestMethod]
        public void PlayerTwo_Winner_Scissors()
        {
            var game = new Game(new List<PlayerGame>()
                       {
                           new PlayerGame("Maria","P"),
                           new PlayerGame("John","S")
                       });

            Assert.AreEqual(game.rps_game_winner().Name, "John");
        }

        [TestMethod]
        public void PlayerTwo_Winner_Paper()
        {
            var game = new Game(new List<PlayerGame>()
                       {
                           new PlayerGame("Maria","R"),
                           new PlayerGame("John","P")
                       });

            Assert.AreEqual(game.rps_game_winner().Name, "John");
        }
        #endregion Part A
    }
}
