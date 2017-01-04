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
        public PlayerGame rps_game_winner(List<PlayerGame> _listPlayerGame)
        {
            if (IsValidNumberPlayers(_listPlayerGame))
                throw new WrongNumberOfPlayersError("Wrong number of players. Allowed just 2 players!");
            else if (IsValidStrategy(_listPlayerGame))
                throw new NoSuchStrategyError("There is a or more invalid strategy. Allowed just 'R','S' or 'P'.");
            else
                return PlayerWinner(_listPlayerGame);
        }

        public bool IsValidNumberPlayers(List<PlayerGame> _listPlayerGame)
        {
            return _listPlayerGame.Count() != 2;
        }

        public bool IsValidStrategy(List<PlayerGame> _listPlayerGame)
        {
            return !(_listPlayerGame.Where(x => x.Played.Equals("R") || x.Played.Equals("S") || x.Played.Equals("P")).Count().Equals(2));
        }

        public PlayerGame PlayerWinner(List<PlayerGame> _listPlayerGame)
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
