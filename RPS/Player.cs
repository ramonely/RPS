using System;
using System.Collections.Generic;
using System.Text;

namespace RPS
{
    public abstract class Player
    {
        public string Name { get; set; }
        public RPS Game { get; set; }

        public Player(string name)
        {
            Name = name;
        }

        public enum RPS
        {
            Rock,
            Paper,
            Scissors
        }

        public abstract RPS GenerateRPS();
    }
}