using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleship
{
    class HumanP : Player
    {
        public HumanP()
        {

        }

        public override void SetGameboard()
        {
            Console.Clear();
            string setGameBoardString1 = "Okay, " + name + ", set the location of your " + ships[0].name + ". [A1 thru T20]";
            Console.WriteLine(setGameBoardString1);
            ships[0].location = Console.ReadLine();
            for (int i = 1; i < ships.Count; i++)
            {
                Console.Clear();
                string setGameBoardString2 = "Now set the location of your " + ships[i].name + ". [A1 thru T20]";
                Console.WriteLine(setGameBoardString2);
                ships[i].location = Console.ReadLine();
            }
            
        }
    }
}
