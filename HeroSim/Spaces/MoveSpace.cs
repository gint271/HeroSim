using System;
using System.Collections.Generic;
using System.Text;

namespace HeroSim
{
    class MoveSpace: Space
    {
        int moveNumber;

        public MoveSpace(int moveNumber)
        {
            this.moveNumber = moveNumber;
        }

        public override void Land(BoardState state)
        {
            state.consecutiveTraining = 0;
            state.move(moveNumber);
        }
    }
}
