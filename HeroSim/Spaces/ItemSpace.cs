using System;
using System.Collections.Generic;
using System.Text;

namespace HeroSim.Spaces
{
    class ItemSpace : Space
    {
        public override void Land(BoardState state)
        {
            state.consecutiveTraining = 0;
        }
    }
}
