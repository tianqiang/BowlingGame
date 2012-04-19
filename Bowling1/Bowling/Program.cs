using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bowling
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Game
    {
        internal void Throw(int pins)
        {
            Score = pins;
        }

        public int Score { get; set; }

        internal void roll(int pins)
        {
            Score +=  pins;
        }
    }
}
