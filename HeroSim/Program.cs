using HeroSim.Spaces;
using System;

namespace HeroSim
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalRolls = 0;
            int maxRolls = int.MinValue;
            int minRolls = int.MaxValue;
            for (int i = 0; i < 10000; i++)
            {
                var state = new BoardState();
                var dice = new Random();

            

                while (state.destructionCount < 10)
                {
                    state.rollCount += 1;
                    int distance = dice.Next(1, 7);
                    state.move(distance);
                }

                totalRolls += state.rollCount;
                maxRolls = state.rollCount > maxRolls ? state.rollCount : maxRolls;
                minRolls = state.rollCount < minRolls ? state.rollCount : minRolls;
                Console.WriteLine($"{state.rollCount}");
            }
        }
    }
}
