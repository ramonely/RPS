using System;
using System.Collections.Generic;
using System.Text;

namespace RPS
{
    internal class UserPlayer : Player
    {
        public UserPlayer(string name) : base(name)
        {
        }

        public override RPS GenerateRPS()

        {
            Console.Write($"Pick a number for your move {Name} 1) Rock 2) Paper 3) Scissors: ");
            int letGo = Convert.ToInt32(Console.ReadLine());
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