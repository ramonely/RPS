using System;
using System.Collections.Generic;
using System.Text;

namespace RPS
{
    internal class Rocky : Player
    {
        public Rocky(string name) : base(name)
        {
        }

        public override RPS GenerateRPS()

        {
            return RPS.Rock;
        }
    }
}