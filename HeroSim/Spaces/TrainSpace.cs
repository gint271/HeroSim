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
            switch (state.consecutiveTraining)
            {
                case 0: state.power += 5;
                    break;
                case 1: state.power += 10;
                    break;
                default: state.power += 20; // Assumes power gain stays at 20 for streaks above 3.
                    break;
            }
            state.consecutiveTraining += 1;
        }
    }
}
