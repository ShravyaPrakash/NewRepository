using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class Problem16
    {
        static void Main()
        {
            int player = 100;
            string str;
            for (int i = 0; i < 4; i++)
            {
                Console.Write("enter hit or miss : ");
                str = Console.ReadLine();
                if (str == "hit")
                    player += 10;
                else if (str == "miss")
                    player -= 20;

            }
            Console.WriteLine($"the player score after 4 shoot: {player}");
        }
    }
