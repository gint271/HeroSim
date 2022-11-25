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
            int[] spaceLandingCounts = new int[30];

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

                for (int position = 0; position < 30; position++)
                {
                    spaceLandingCounts[position] += state.spaceLandingCounts[position];
                }

                log.AppendLine($"{state.destructionCount}\t{state.earnedItems[(int)Item.SupportCommonConsole]}\t{state.earnedItems[(int)Item.DefendersCommonConsole]}\t{state.earnedItems[(int)Item.AttackersCommonConsole]}" +
                    $"\t{state.earnedItems[(int)Item.ManufacturerCommonConsole]}\t{state.earnedItems[(int)Item.HourResourceBox]}\t{state.earnedItems[(int)Item.REEnergy]}");
            }

            log.AppendLine(String.Join("\n", spaceLandingCounts));

            using (StreamWriter writer = new StreamWriter("./outfile.txt"))
            {
                writer.Write(log.ToString());
            }
        }
    }
}
