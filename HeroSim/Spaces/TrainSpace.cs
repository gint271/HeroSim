using System;
using System.Collections.Generic;
using System.Text;

namespace HeroSim.Spaces
{
    class TrainSpace : Space
    {
        public override void Land(BoardState state)
        {
            // Streak bonus resets after 3.
            switch (state.consecutiveTraining % 3)
            {
                case 0: state.power += 5;
                    break;
                case 1: state.power += 10;
                    break;
                case 2: state.power += 20; 
                    break;
            }
            state.consecutiveTraining += 1;
            state.earnedItems[(int)Item.ManufacturerCommonConsole] += 1;
        }
    }
}
