using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Console.WriteLine();
                //TODO Create a Monster
                //TODO Create a Room

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
                    string choice = Console.ReadLine().ToUpper();

                    switch (choice)
                    {
                        case "A":
                            Console.Clear();
                            Console.WriteLine("Attack");
                            //TODO Create Attack
                            break;

                        case "B":
                            Console.Clear();
                            Console.WriteLine("Run Away");
                            //TODO Create Run Away
                            exit = true;
                            break;

                        case "C":
                            Console.Clear();
                            Console.WriteLine("Character Info");
                            //TODO Create Character Info
                            break;

                        case "D":

                            Console.Clear();
                            Console.WriteLine("Monster Info");
                            //TODO Create Monster Info
                            break;

                        case "E":

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

                } while (!exit);//end inner loop
                Console.WriteLine();


            } while (!quit);//end main loop





            //QUSTIONS 
            //1.Do we need to do a random for the attack? or how do I get it to break out of innerloop for win and both loops for lose?



        }//end Main()
    }//end class
}//end namespace

