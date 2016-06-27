using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    public class VirtualPet
    {
        public string Name { get; set; }
        public int NumberOfLegs { get; set; }
        public bool Tail { get; set; }
        public int Weight { get; set; }
        public string AnimalType { get; set; }
        public int Hunger { get; set; }
        public int Thirst { get; set; }
        public int Waste1 { get; set; }
        public int Waste2 { get; set; }
        public int Tiredness { get; set; }
        public int Boredom { get; set; }



        public VirtualPet()
        {
            Hunger = 0;
            Thirst = 0;
            Waste1 = 0;
            Waste2 = 0;
            Tiredness = 0;
            Boredom = 0;
        }

        public void DisplayPetStatus()
        {
            // display heading in blue
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\t\t\t    Your virtual pet");
            Console.ForegroundColor = ConsoleColor.White;

            // print out animal user created
            Console.WriteLine();
            Console.WriteLine("\t\t{0}, a {1}, with {2} legs, weighing {3} pounds", Name, AnimalType, NumberOfLegs, Weight);
            Console.WriteLine();

            // display the pet with the right amount of legs
            DisplayPet();
            
            // display status of pet statistics
            Console.WriteLine("\t\t\t  * STATUS OF YOUR PET * ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("\tYour pet will die if any of the pet indicators reach 100 !");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("\t\tHungry\tThirsty\tPee\tPoop\tTired\tBored");
            Console.WriteLine("\t\t______\t_______\t___\t____\t_____\t_____");

            // if level is 80 or over
            if (Hunger > 75)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\t\t{0}", Hunger);
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.Write("\t\t{0}", Hunger);
                
            }

            if (Thirst > 75)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\t{0}", Thirst);
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.Write("\t{0}", Thirst);
            }


            if (Waste1 > 75)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\t{0}", Waste1);
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.Write("\t{0}", Waste1);
            }


            if (Waste2 > 75)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\t{0}", Waste2);
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.Write("\t{0}", Waste2);
                   
            }


            if (Tiredness > 75)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\t{0}", Tiredness);
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.Write("\t{0}", Tiredness);
            }


            if (Boredom > 75)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\t{0}\n", Boredom);
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.Write("\t{0}\n", Boredom);
            }

            

           //Console.WriteLine("\t\t{0}\t{1}\t{2}\t{3}\t{4}\t{5}", Hunger, Thirst, Waste1, Waste2, Tiredness, Boredom);

        }

        // display the menu of actions, run tick every time an action is chosen
        public void DisplayActionMenu()
        {

            Console.WriteLine();
            Console.WriteLine("1 - Give food");
            Console.WriteLine("2 - Give water");
            Console.WriteLine("3 - Pee break");
            Console.WriteLine("4 - Poop break");
            Console.WriteLine("5 - Nap time ");
            Console.WriteLine("6 - Play time");
            Console.WriteLine("7 - Return Pet");
            Console.WriteLine("");
            Console.Write("Enter your option : ");
            Tick();

           
        }

        // returns true/false depending on if 100 is reached
        public bool ReachedTheLimit()
        {
            bool reachedTheLimit = false;

            if (Hunger >= 100)
            {
                reachedTheLimit = true;
            }

            if (Thirst >= 100)
            {
                reachedTheLimit = true;
            }

            if (Waste1 >= 100)
            {
                reachedTheLimit = true;
            }

            if (Waste2 >= 100)
            {
                reachedTheLimit = true;
            }

            if (Boredom >= 100)
            {
                reachedTheLimit = true;
            }

            if (Tiredness >= 100)
            {
                reachedTheLimit = true;
            }

            return reachedTheLimit;
        }

        // adds to the instance variables
        public void Tick()
        {
            Hunger += 10;
            Thirst += 5;
            Waste1 += 7;
            Waste2 += 3;
            Boredom += 6;
            Tiredness += 8;

        }

        // displays the pet with the right amount of legs
        public void DisplayPet()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("                                   ^_____^     \n");
            Console.Write("                                  ( o   o )    \n");
            Console.Write("                                   \\__=__/    \n");

            // get the size by doing an integer division, set minimum size to 6
            int size = Weight / 10;
            int maxSpace = 38;
            if (size < 6)
            {
                size = 6;
            }

      
            for (int i = 1;i <= (maxSpace-(size/2));i++)
            {
                             
                    Console.Write(" ");
             
            }
            

            for (int i = 1;i <=size;i++)
            {
                if (i == 1)
                {
                    Console.Write("(");
                }
                else
                {
                    Console.Write("_");
                }
            }
            Console.Write(")");
            if (Tail)
            {
                Console.Write("=== ");
            }
            Console.WriteLine();
            
            
            switch(NumberOfLegs)
            {
                case 1:
                    
                    Console.WriteLine("                                     _|");
                    break;
                case 2:
                    
                    Console.WriteLine("                                   _|  _|");
                    break;
                case 3:
                    
                    Console.WriteLine("                                   _|_|_| ");
                    break;
                case 4:
                    
                    Console.WriteLine("                                 _|_| _|_|");
                    break;
            }

            Console.WriteLine();
            

        }

        // called from a thread, calls tick everytime an interval of time has past
        public void RunTick()
        {
            while (!ReachedTheLimit())
            {
                // check if the limit is reached every second but do it for an interval of time
                int timeInterval = 20;
                for (int i = 1; i <= timeInterval; i++)
                {
                    System.Threading.Thread.Sleep(1000);
                    if (ReachedTheLimit())
                    {
                        i = 21;
                    }
                    
                }

                // if the limit has not been reached, call tick and update statistics
                if (!ReachedTheLimit())
                {
                    Tick();
                    Console.Clear();
                    DisplayPetStatus();
                    DisplayActionMenu();
                }
                // otherwise return
                else
                {
                    continue;
                }
                
            }

           // Console.Clear();
           // Console.WriteLine("Your pet is died  - press any key to end program.");
           // string answer = Console.ReadLine();
 

        }

        public void FeedPet()
        {
            Hunger = 0;
            Waste2 += 10;
        }

        public void WaterPet()
        {
            Thirst = 0;
            Waste1 += 15;
        }

        public void PeeBreak()
        {
            Waste1 = 0;
            Thirst += 6;
        }

        public void PoopBreak()
        {
            Waste2 = 0;
            Hunger += 11;
        }

        public void NapTime()
        {
            Tiredness = 0;
            Boredom += 14;
        }

        public void PlayTime()
        {
            Boredom = 0;
            Tiredness += 20;
        }


    }
}
