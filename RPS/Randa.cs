using System;
using System.Collections.Generic;
using System.Text;

namespace RPS
{
    internal class Randa : Player
    {
        public Randa(string name) : base(name)
        {
        }

        public override RPS GenerateRPS()

        {
            Random selection = new Random();
            int letGo = selection.Next(1, 3);
            if (letGo == 1)
            {
                return RPS.Rock;
            }
            else if (letGo == 2)
            {
                return RPS.Paper;
            }
            else
            {
                return RPS.Scissors;
            }
        }
    }
}