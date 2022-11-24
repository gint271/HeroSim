using HeroSim.Spaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeroSim
{
    class BoardState
    {
        public int rollCount = 0;
        public int position = 0;
        public int power = 0;
        public int consecutiveTraining = 0;
        public int destructionCount = 0;

        public static Space[] board = new Space[30] {
                new MoveSpace(3),
                new TrainSpace(),
                new RestSpace(),
                new ItemSpace(),
                new CombatSpace(),
                new RestSpace(),
                new TrainSpace(),
                new MoveSpace(-2),
                new ItemSpace(),
                new TrainSpace(),
                new MoveSpace(3),
                new PoorSpace(),
                new ItemSpace(),
                new TrainSpace(),
                new CombatSpace(),
                new PoorSpace(),
                new MoveSpace(-1),
                new ItemSpace(),
                new RestSpace(),
                new TrainSpace(),
                new ItemSpace(),
                new MoveSpace(4),
                new RestSpace(),
                new ItemSpace(),
                new CombatSpace(),
                new TrainSpace(),
                new PoorSpace(),
                new ItemSpace(),
                new RestSpace(),
                new ItemSpace()
            };

        public void move(int distance)
        {
            position += distance;
            if (position > 29)
            {
                power += 50;
                position -= 30;
            }

            board[position].Land(this);

            if (power > 100)
            {
                destructionCount += 1;
                power -= 100;
            }
        }
    }
}
