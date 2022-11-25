using System;
using System.Collections.Generic;
using System.Text;

namespace HeroSim.Spaces
{
    class ItemSpace : Space
    {
        Item item;
        public ItemSpace(Item item)
        {
            this.item = item;
        }

        public override void Land(BoardState state)
        {
            state.consecutiveTraining = 0;
            state.earnedItems[(int)item] += 1;
        }
    }
}
