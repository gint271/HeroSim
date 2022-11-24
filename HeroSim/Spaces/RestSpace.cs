using System;
using System.Collections.Generic;
using System.Text;

namespace HeroSim.Spaces
{
    class RestSpace : Space
    {
        public override void Land(BoardState state)
        {
            state.power += 5;
            state.consecutiveTraining = 0;
        }
    }
}
