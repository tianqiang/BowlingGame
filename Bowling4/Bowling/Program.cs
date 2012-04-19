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
                 if (isStrike(frameIndex))
                 {
                     Score += 10 + strikeBonus(frameIndex);
                     frameIndex++;
                 }
                 else if( isSpare(frameIndex))
                 {
                     Score += 10 + spareBonus(frameIndex);
                     frameIndex += 2;
                 }
                 else
                 {
                     Score += sumOfBallsInFrame(frameIndex);
                     frameIndex += 2;
                 }
             }

             return Score;


        }
        private bool isStrike(int frameIndex)
        {
            return rolls[frameIndex] == 10;
        }

        private int sumOfBallsInFrame(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1];
        }

        private int spareBonus(int frameIndex)
        {
            return rolls[frameIndex + 2];
        }

        private int strikeBonus(int frameIndex)
        {
            return rolls[frameIndex + 1] + rolls[frameIndex + 2];
        }

        



        private bool isSpare(int frameIndex)
        {
            return rolls[frameIndex] +rolls[frameIndex + 1] == 10;
        }


        internal void roll(int pins)
        {
            rolls[currentRoll++] = pins;

        }
    }
}
