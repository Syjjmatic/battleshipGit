using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleship
{
    abstract class Player
    {
        public string name;
        public int score;
        public Gameboard setGameBoard;
        public Gameboard attackGameBoard;
        public string enterAName;
        public List<Ship> ships;
        
        public Player()
        {
            score = 0;
            setGameBoard = new Gameboard();
            attackGameBoard = new Gameboard();
            ships = new List<Ship> { new AircraftCarrier(), new Battleship(), new Submarine(), new Destroyer() };
        }

        public void GetName(string player)
        {
            Console.Clear();
            enterAName = "Enter a name for " + player + ":";
            Console.WriteLine(enterAName);
            name = Console.ReadLine();
            while (name == "")
            {
                string error = "You did not enter a name. Try again.";
                Console.WriteLine(error);
                name = Console.ReadLine();
            }
        }

        public abstract void SetGameboard();
        

    }
}
