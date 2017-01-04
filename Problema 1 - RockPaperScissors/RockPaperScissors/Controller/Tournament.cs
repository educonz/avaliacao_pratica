using RockPaperScissors.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Controller
{
    public class Tournament
    {
        public PlayerGame rps_tournament_winner(List<PlayerGame>[][] listRounds)
        {
            var winnerOneRound = new List<PlayerGame>();

            foreach (var rounds in listRounds)
            {
                var winnerSecondRound = new List<PlayerGame>();
                foreach (var round in rounds)
                {
                    winnerSecondRound.Add(VerifyRoundWinner(round));
                }
                winnerOneRound.Add(VerifyRoundWinner(winnerSecondRound));
            }

            return VerifyRoundWinner(winnerOneRound);
        }

        public PlayerGame VerifyRoundWinner(List<PlayerGame> players)
        {
            return new Game().rps_game_winner(players);
        }
    }
}
