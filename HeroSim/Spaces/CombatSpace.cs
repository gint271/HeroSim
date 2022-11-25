using System;
using System.Collections.Generic;
using System.Text;

namespace HeroSim.Spaces
{
    class CombatSpace : Space
    {
        private static Random random = new Random();
        public override void Land(BoardState state)
        {
            //Assume 50/50 chance of +5 or +10.
            if (random.Next(0, 2) == 0)
                state.power += 5;
            else
                state.power += 10;
            state.consecutiveTraining = 0;
        }
    }
}
