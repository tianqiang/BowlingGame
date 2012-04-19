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
        private int[] rolls = new int[21];
        private int currentRoll = 0;
        internal void Throw(int pins)
        {
            Score = pins;
        }

        public int Score { get; set; }

        public int score()
        {
             Score = 0;
            int frameIndex = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (isSpare(frameIndex))
                {
                    Score += 10 + rolls[frameIndex + 2];
                    frameIndex += 2;
                }
                else
                {
                    Score += rolls[frameIndex] +
                             rolls[frameIndex + 1];
                    frameIndex += 2;
                }
            }
            return Score;

        }

        private bool isSpare(int frameIndex)
        {
            return rolls[frameIndex] +
                   rolls[frameIndex + 1] == 10;
        }


        internal void roll(int pins)
        {
            rolls[currentRoll++] = pins;
          //  Score +=  pins;

        }
    }
}
