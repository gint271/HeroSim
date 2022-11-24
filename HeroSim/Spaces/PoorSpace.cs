using System;
using System.Collections.Generic;
using System.Text;

namespace HeroSim.Spaces
{
    class PoorSpace : Space
    {
        public override void Land(BoardState state)
        {
            state.power -= 10;
            // Assumption that it can't go below zero.
            state.power = state.power < 0 ? 0 : state.power;
            state.consecutiveTraining = 0;
        }
    }
}
