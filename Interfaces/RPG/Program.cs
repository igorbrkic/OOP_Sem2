using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponClassLibrary;
using PlayerClassLibrary;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> ListPlayer = new List<Player>();
            int parseResult;
            //CreatePlayer
            DisplayMainMenu();

            void CreatePlayer()
            {
                string pName;
                int HP;
                int AP;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Enter Name");
                    pName = Console.ReadLine();
                } while (pName != "");
                do
                {
                    Console.Clear();
                    Console.WriteLine("Enter Health Total");
                } while (IntParse(Console.ReadLine()));
                HP = parseResult;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Enter AP Total");
                } while (IntParse(Console.ReadLine()));
                AP = parseResult;
                ListPlayer.Add(new Player(pName, HP, AP));
            }

            void DisplayMainMenu()
            {
                Console.Clear();
                Console.WriteLine("1. Create Player");
                Console.WriteLine("2. Start");
                Console.WriteLine("3. Quit");
                string menuInput = Console.ReadLine();
                switch (menuInput)
                {
                    case "1":
                        CreatePlayer();
                        break;
                    case "2":

                        break;
                    case "3";
                        Console.ReadLine("Click the cross in the top right.");
                    do
                    {
                        //stuff
                    } while (true);
                default:
                    DisplayMainMenu();
                    break;
                }
            }
        bool IntParse(string Input)
        {
            if (int.TryParse(Input, out parseResult))
            {
                return true;
            }
            else return false;
        }
    }
}
