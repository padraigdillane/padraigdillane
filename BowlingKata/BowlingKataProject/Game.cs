using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingKataProject
{
    public class Game
    {
        private int[] rolls = new int[21];
        private int currentRoll = 0;

        public void roll(int pins)
        {
            rolls[currentRoll] = pins;
            currentRoll++;
        }

        public int scoreGame()
        {
            int score = 0;
            int frameIndex = 0; //current frame

            for (int frame = 0; frame < 10; frame++)
            {
                int wholeFrame = rolls[frameIndex] + rolls[frameIndex + 1];
               

                if (isStrike(frameIndex))
                {
                    score += rolls[frameIndex] + stikeBonus(frameIndex);
                    frameIndex++;
                }

                else if (isSpare(frameIndex))//spare
                {
                    score += rolls[frameIndex] + spareBonus(frameIndex);
                    frameIndex += 2;
                }
                else
                {
                    score += wholeFrame;
                    frameIndex += 2;
                }
                
             
            }
            return score;
        }

        private int spareBonus(int frameIndex)
        {
            return rolls[frameIndex + 1] + rolls[frameIndex + 2];
        }

        private int stikeBonus(int frameIndex)
        {
            return rolls[frameIndex + 1] + rolls[frameIndex + 2];
        }

        public bool isSpare(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1] == 10;
        }

        public bool isStrike(int frameIndex)
        {
            return rolls[frameIndex] == 10;
        }
    }
}
