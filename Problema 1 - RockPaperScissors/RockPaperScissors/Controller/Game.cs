using RockPaperScissors.Exceptions;
using RockPaperScissors.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Controller
{
    public class Game
    {
        private List<PlayerGame> _listPlayerGame;

        public Game(List<PlayerGame> listPlayers)
        {
            _listPlayerGame = listPlayers;
        }

        public PlayerGame rps_game_winner()
        {
            if (IsValidNumberPlayers())
                throw new WrongNumberOfPlayersError("Wrong number of players. Allowed just 2 players!");
            else if (IsValidStrategy())
                throw new NoSuchStrategyError("There is a or more invalid strategy. Allowed just 'R','S' or 'P'.");
            else
                return PlayerWinner();
        }

        public bool IsValidNumberPlayers()
        {
            return _listPlayerGame.Count() != 2;
        }

        public bool IsValidStrategy()
        {
            return !(_listPlayerGame.Where(x => x.Played.Equals("R") || x.Played.Equals("S") || x.Played.Equals("P")).Count().Equals(2));
        }

        public PlayerGame PlayerWinner()
        {
            var playerOne = _listPlayerGame[0];
            var playerTwo = _listPlayerGame[1];

            return ((playerOne.Played.Equals("R") && playerTwo.Played.Equals("S")) ||
                    (playerOne.Played.Equals("S") && playerTwo.Played.Equals("P")) ||
                    (playerOne.Played.Equals("P") && playerTwo.Played.Equals("R")) ||
                    (playerOne.Played.Equals(playerTwo.Played))) ? playerOne : playerTwo;
        }
    }
}
