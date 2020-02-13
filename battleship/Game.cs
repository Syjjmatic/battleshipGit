using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleship
{
    class Game
    {
        public string introString;
        public string displayRules;
        public List<Ship> ships;
        public string gameModeString;
        public Game()
        {
            ships = new List<Ship> { new AircraftCarrier(), new Battleship(), new Submarine(), new Destroyer() };
        }

        public void Introduction()
        {
            introString = "Welcome to Battleship!\n\n";
            Console.WriteLine(introString);
            System.Threading.Thread.Sleep(1000);
        }

        public void DisplayRules()
        {
            displayRules = "The rules are as follows:\nEach player will have four [" + ships.Count + "] different ships: an " +
                ships[0].name + ", " + ships[1].name + ", " + ships[2].name + ", and " + ships[3].name + ".\n" +
                "\nEach ship has a different size value. The sizes are as follows: \n" +
                ships[0].name + " = " + ships[0].size + "\n" +
                ships[1].name + " = " + ships[1].size + "\n" +
                ships[2].name + " = " + ships[2].size + "\n" +
                ships[3].name + " = " + ships[3].size + "\n\n" +
                "Ships will be placed horizontally or vertically on a 20x20 grid. \nThe ship's size cannot extend past the boundaries of the grid.\n\n" +
                "Once the ships are placed, players will go back and forth, voicing\nto the opposite player a location that they'd like to attack.\n" +
                "Once an attack has been declared, the opponent's ship will be 'hit'\nor 'missed.' The first player to sink all of his or her opponent's ships...\n\n" +
                "... WINS! ";
            Console.WriteLine(displayRules);
        }

        public void GameMode()
        {
            Console.Clear();
            gameModeString = "Which game mode do you want to play?\n\n" +
                "[1] One player\n" +
                "[2] Two players\n" +
                "[3] Watch the AI battle it out!";

        }
        public void init()
        {
            Introduction();
            DisplayRules();
            Console.ReadLine();

        }
    }
}
