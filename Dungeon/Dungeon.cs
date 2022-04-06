using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace Dungeon
{
    internal class DungeonApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            //TODO Create a Player

            bool quit = false;//main loop

            do
            {
                Console.WriteLine(GetRoom());

                //TODO Create a Monster
              

                bool exit = false;//inner loop
                do
                {
                    //Display the Menu
                    Console.WriteLine("Please make a selection:\n" +
                        "A. Attack\n" +
                        "B. Run Away\n" +
                        "C. Character Info\n" +
                        "D. Monster Info\n" +
                        "E. Exit");

                    //store users input
                    ConsoleKey choice = Console.ReadKey(true).Key;//Executes on key press

                    switch (choice)
                    {
                        case ConsoleKey.A:
                            Console.Clear();
                            Console.WriteLine("Attack");
                            //TODO Create Attack

                            //after combat, if we win, set reload = true
                            break;

                        case ConsoleKey.B:
                            Console.Clear();
                            Console.WriteLine("Run Away");
                            //TODO Create Run Away
                            exit = true;
                            break;

                        case ConsoleKey.C:
                            Console.Clear();
                            Console.WriteLine("Character Info");
                            //TODO Create Character Info
                            break;

                        case ConsoleKey.D:

                            Console.Clear();
                            Console.WriteLine("Monster Info");
                            //TODO Create Monster Info
                            break;

                        case ConsoleKey.E:
                        case ConsoleKey.X:

                            Console.Clear();
                            Console.WriteLine("Thank you for playing!");
                            exit = true;
                            quit = true;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Invalid input. Please try again.");
                            break;
                    }

                } while (!exit && !quit);//end inner loop
                Console.WriteLine();


            } while (!quit);//end main loop





            //QUSTIONS 
            //1.Do we need to do a random for the attack? or how do I get it to break out of innerloop for win and both loops for lose?



        }//end Main()

        //Create Room Descriptions
        //TODO Update descriptions

        private static string GetRoom()
        {
            string[] roomDescription =
         {
            "Room 1",
            "Room 2",
            "Room 3",
            "Room 4"

            };//End Room Descriptions

            Random rand = new Random();

            int indexNbr = rand.Next(roomDescription.Length);

            string room = roomDescription[indexNbr];

            return room;
        }//end GetRoom



    }//end class
}//end namespace

