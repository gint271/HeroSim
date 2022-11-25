using HeroSim.Spaces;
using System;
using System.IO;
using System.Text;

namespace HeroSim
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder log = new StringBuilder();
            for (int i = 0; i < 10000; i++)
            {
                var state = new BoardState();
                var dice = new Random();

            
                // FTP should be around 251 rolls
                for (int j = 0; j < 251; j++)
                {
                    state.rollCount += 1;
                    int distance = dice.Next(1, 7);
                    state.move(distance);
                }

                log.AppendLine($"{state.destructionCount}\t{state.earnedItems[(int)Item.SupportCommonConsole]}\t{state.earnedItems[(int)Item.DefendersCommonConsole]}\t{state.earnedItems[(int)Item.AttackersCommonConsole]}");
            }

            using (StreamWriter writer = new StreamWriter("./outfile.txt"))
            {
                writer.Write(log.ToString());
            }
        }
    }
}
