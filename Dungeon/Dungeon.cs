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
            Console.Title = "Hospital of Horror";
            Console.WriteLine("Your encounter begins...");

            int score = 0;

            Weapon traumaShears = new Weapon(3, 15, "Trama Shears", 10, WeaponType.Sciccors, false);

            Player player = new Player("Nurse Ratchet", 75, 8, 60, 60, Race.Nurse, traumaShears);

            bool quit = false;//main loop

            do
            {
                Console.WriteLine(GetRoom());

                DementedPatient patient = new DementedPatient("Ima Pain", 35, 60, 40, 10, 15, 3, "They may look fragile, but they can move quickly");

                EvilTraumaSurgeon surgeon = new EvilTraumaSurgeon("Dr. McClain", 50, 75, 35, 10, 10, 20, "Appears to be exhausted, but is well trained for long hours", 4, 8);

                Anestesiologist anestesiologist = new Anestesiologist("Clif Peda", 75, 75, 40, 20, 10, 35, "High and mighty", true);

                AngryFamilyMember familyMember = new AngryFamilyMember("Karen Squared", 50, 65, 20, 15, 5, 10, "On a rampage", true);

                Monster[] monsters = { patient, surgeon, anestesiologist, familyMember };

                Random rand = new Random();
                int randomNbr = rand.Next(monsters.Length);
                Monster monster = monsters[randomNbr];

                Console.WriteLine("\nIn this room you encounter: "+ monster.Name);
              

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
                    Console.Clear();

                    switch (choice)
                    {
                        case ConsoleKey.A:
                            Combat.DoBattle(player, monster);

                            if (monster.Life <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You killed {0}", monster.Name);
                                Console.ResetColor();
                                score++;
                                exit = true;
                            }
                            
                            Console.WriteLine("Attack");
                            

                            //after combat, if we win, set reload = true
                            break;

                        case ConsoleKey.B:
                           Console.WriteLine($"{monster.Name} attacks you as you flee!");
                            Combat.DoAttack(monster, player);

                            Console.WriteLine();
                            exit = true;
                            break;

                        case ConsoleKey.C:                           
                            Console.WriteLine(player);
                            Console.WriteLine("Monsters defeated " + score);
                            break;

                        case ConsoleKey.D:

                            Console.Clear();
                            Console.WriteLine(monster);                            
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

                    if (player.Life <= 0)
                    {
                        Console.WriteLine("You have been defeated by {0}!", monster.Name);
                        exit = true;
                    }

                } while (!exit && !quit);//end inner loop
                Console.WriteLine("You defeated " + score + " monster" + 
                    ((score ==1) ? "." : "s."));


            } while (!quit);//end main loop





          



        }//end Main()

        //Create Room Descriptions
        //TODO Update descriptions

        private static string GetRoom()
        {
            string[] roomDescription =
         {
            "Blood covered trauma bay. Blinding lights are shining in your eyes.",
            "Dark, dingy and crowded room in the ICU",
            "Crowded ER waiting room. Angry patients everywhere.",
            "Bright and cold hallway."

            };//End Room Descriptions

            Random rand = new Random();

            int indexNbr = rand.Next(roomDescription.Length);

            string room = roomDescription[indexNbr];

            return room;
        }//end GetRoom



    }//end class
}//end namespace

