using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Exceptions
{
    public class NoSuchStrategyError : Exception
    {
        public NoSuchStrategyError(string message) : base(message) { }
        public NoSuchStrategyError() { }
    }
}
