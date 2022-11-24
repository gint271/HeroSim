using System;
using System.Collections.Generic;
using System.Text;

namespace HeroSim.Spaces
{
    class CombatSpace : Space
    {
        public override void Land(BoardState state)
        {
            //TODO: Random bonus.
            state.power += 5;
            state.consecutiveTraining = 0;
        }
    }
}
