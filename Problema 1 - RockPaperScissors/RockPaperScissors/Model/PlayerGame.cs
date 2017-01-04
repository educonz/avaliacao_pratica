using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Model
{
    public class PlayerGame
    {
        public PlayerGame(string name, string played)
        {
            this.Name = name;
            this.Played = played;
        }

        public PlayerGame() { }

        public string Name { get; set; }
        public string Played { get; set; }
    }
}
