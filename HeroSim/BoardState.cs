using HeroSim.Spaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeroSim
{
    class BoardState
    {
        public int rollCount;
        public int position;
        public int power;
        public int consecutiveTraining;
        public int destructionCount;
        public int[] earnedItems;

        public static Space[] board = new Space[30] {
            new MoveSpace(3),
            new TrainSpace(),
            new RestSpace(),
            new ItemSpace(Item.AttackersCommonConsole),
            new CombatSpace(),
            new RestSpace(),
            new TrainSpace(),
            new MoveSpace(-2),
            new ItemSpace(Item.DefendersCommonConsole),
            new TrainSpace(),
            new MoveSpace(3),
            new PoorSpace(),
            new ItemSpace(Item.SupportCommonConsole),
            new TrainSpace(),
            new CombatSpace(),
            new PoorSpace(),
            new MoveSpace(-1),
            new ItemSpace(Item.AttackersCommonConsole),
            new RestSpace(),
            new TrainSpace(),
            new ItemSpace(Item.DefendersCommonConsole),
            new MoveSpace(4),
            new RestSpace(),
            new ItemSpace(Item.SupportCommonConsole),
            new CombatSpace(),
            new TrainSpace(),
            new PoorSpace(),
            new ItemSpace(Item.DefendersCommonConsole),
            new RestSpace(),
            new ItemSpace(Item.SupportCommonConsole)
        };

        public BoardState()
        {
            rollCount = 0;
            position = 0;
            power = 0;
            consecutiveTraining = 0;
            destructionCount = 0;
            earnedItems = new int[7];
        }

        public void move(int distance)
        {
            position += distance;
            if (position > 29)
            {
                power += 50;
                position -= 30;
            }

            board[position].Land(this);

            if (power > 100)
            {
                destructionCount += 1;
                power = 0;
            }
        }
    }

    public enum Item { 
        SupportCommonConsole,
        DefendersCommonConsole,
        AttackersCommonConsole,
        ElysionCommonConsole,
        MissilisCommonConsole,
        TetraCommonConsole,
        PilgrimCommonConsole,
    }
}
