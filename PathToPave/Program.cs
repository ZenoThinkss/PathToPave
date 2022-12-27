using System.Dynamic;
using System.Transactions;

namespace PathToPave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Introduction/Title
            
            string welcome = "Welcome, To our Path To Pave";
            string title = "Dungeon";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (welcome.Length / 2)) + "}", welcome));
            Console.Title = title;

            #endregion


            #region Player Creation
            //let player choose name, and let them choose a weapon Weapon.PickWeapon()
            //Enum.GetValues<Race>().ToList() -- See ClassicMonsters example in enums = choose class

            int score = 0;
            //TODO create a way to keep score, 
            //define the experience propertie in character = inherit down to created player and monster to scale levelling
            //define how scalling would work 

            //TODO create weapon
            //create a weapon object
            //Weapon sword = new Wapon(minDamage, maxDamage, name, bonushitChance, type) can add Fields  here 

            //TODO create player object
            #endregion


            #region Main Game Loop 
            bool quit = false;
            do
            {

                Console.Clear();

                //TODO create a random Get room 
                Console.WriteLine(GetRoom());
                
                
                #region Gameplay loop
                bool reload = false;

                do
                {

                    #region Gameplay Menu

                    Console.WriteLine("W) Attack\n" + "A) Player Info\n" + "S) Run Away\n" + "D) Monster Info\n" + "X) Exit\n" + "");

                    string menuChoice = Console.ReadKey(true).Key.ToString();

                    switch (menuChoice) 
                    {

                        case "W":
                            //TODO Combat
                            
                            Console.WriteLine("Attacking");
                            reload= true;
                            break;

                        case "A":
                            
                            //TODO display player info
                            Console.WriteLine("Player:");
                            break;
                        case "D":
                            //TODO display Monster info
                            Console.WriteLine("Monster:");
                            break;
                        case "S":
                            //TODO -- Give an attack of opportuity to the monster 
                            Console.WriteLine("Running");
                            break;
                        case "X":
                            case"E":
                        case "Escape":
                            quit= true;
                            Console.WriteLine("Thanks for playing");
                            break;

                        default:
                            Console.WriteLine("You can't do that here...");
                            break;

                    }//end gameplay switch 



                    #endregion


                } while (!reload && !quit);

                #endregion

            } while (!quit);

            #endregion

        }//end Main()

        #region Custom get room Method

        private static string GetRoom() 
        {

            string[][] rooms = 
            {
                new string[] 
                {
                        "Small room wet, mildewy smell, dimly lit by candles attached to the wall, cob webs covering the corner and the single small round table in the corner",
                        "small room with nothing but a chest on the opposite side of the entrance ",
                        "room with no light"

                },
                new string[] 
                {
                     "medium room with bright light that is almost blinding  you have to cover your eyes with your hand like a visor in order to see",
                    "medium room with only a single light coming in from a small window toward the top of one of the walls the light lands on a door across the room from you",
                     "medium room with a dining table spanning from one side of the room to the other with delicious smelling food is laid out across it"


                },

                new string[] 
                {

                     "large sized room with what looks to be a set of large dog kennels across the left and right walls",
                    "Large room with plants hanging from the cieling and a fountain in the center",
                     "Large room with a very low ceiling you have to crouch to enter"

                }

            };

          
            Random rand = new Random();
            int index = rand.Next(rooms.Length);
            string room = rooms[index][index];
            return room;




        }//end GetRoom()



        #endregion



    }//end class
}//end namespace