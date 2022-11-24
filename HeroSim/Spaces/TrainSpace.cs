using System;
using System.Collections.Generic;
using System.Text;

namespace HeroSim.Spaces
{
    class TrainSpace : Space
    {
        public override void Land(BoardState state)
        {
            //TODO: Consecutive bonus.
            state.power += 5;
            state.consecutiveTraining += 1;
        }
    }
}
