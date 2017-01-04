using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Controller;
using System.Collections.Generic;
using RockPaperScissors.Model;

namespace RockPaperScissorsTest
{
    [TestClass]
    public class TheTournamentTest
    {
        [TestMethod]
        public void Richard_Winner_Tour()
        {
            var listrounds = new List<PlayerGame>[2][];
            listrounds[0] = new List<PlayerGame>[2]
                            {
                                new List<PlayerGame>()
                                {
                                    new PlayerGame("Armando", "P"),
                                    new PlayerGame("Dave", "S")
                                },
                                new List<PlayerGame>()
                                {
                                    new PlayerGame("Richard", "R"),
                                    new PlayerGame("Michael", "S")
                                }
                            };

            listrounds[1] = new List<PlayerGame>[2]
                            {
                                new List<PlayerGame>()
                                {
                                    new PlayerGame("Allen", "S"),
                                    new PlayerGame("Omer", "P")
                                },
                                new List<PlayerGame>()
                                {
                                    new PlayerGame("David E.", "R"),
                                    new PlayerGame("Richard X.", "P")
                                }
                            };

            var tour = new Tournament();

            Assert.AreEqual(tour.rps_tournament_winner(listrounds).Name, "Richard");
        }

        [TestMethod]
        public void Pamela_Winner_Tour()
        {
            var listrounds = new List<PlayerGame>[2][];
            listrounds[0] = new List<PlayerGame>[2]
                            {
                                new List<PlayerGame>()
                                {
                                    new PlayerGame("Armando", "R"),
                                    new PlayerGame("Dave", "S")
                                },
                                new List<PlayerGame>()
                                {
                                    new PlayerGame("Richard", "P"),
                                    new PlayerGame("Michael", "S")
                                }
                            };

            listrounds[1] = new List<PlayerGame>[2]
                            {
                                new List<PlayerGame>()
                                {
                                    new PlayerGame("Allen", "R"),
                                    new PlayerGame("Pamela", "P")
                                },
                                new List<PlayerGame>()
                                {
                                    new PlayerGame("David E.", "R"),
                                    new PlayerGame("Otavio", "P")
                                }
                            };

            var tour = new Tournament();

            Assert.AreEqual(tour.rps_tournament_winner(listrounds).Name, "Pamela");
        }
    }
}
