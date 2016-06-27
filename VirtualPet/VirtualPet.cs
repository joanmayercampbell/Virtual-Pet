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
            Console.WriteLine("\t\t\t Your virtual pet");
            
            Console.WriteLine();            
            Console.WriteLine("\t\t{0}, a {1}, with {2} legs and {3} pounds", Name, AnimalType, NumberOfLegs, Weight);

            Console.WriteLine();
            Console.WriteLine("\t\tStatus of your pet ");
            Console.WriteLine();
            Console.ForegroundColor = Console.Col
            Console.WriteLine();
            Console.WriteLine("\t\tHungry\tThirsty\tPee\tPoop\tTired\tBored");
            Console.WriteLine("\t\t{0}\t{1}\t{2}\t{3}\t{4}\t{5}", Hunger, Thirst, Waste1, Waste2, Tiredness, Boredom);

        }

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

        public void Tick()
        {
            Hunger += 10;
            Thirst +=  5;
            Waste1 += 7;
            Waste2 += 3;
            Boredom += 6;
            Tiredness += 8;
           
        }

        public void RunTick()
        {
            while (!ReachedTheLimit())
            {
                System.Threading.Thread.Sleep(20000);
                Tick();
                Console.Clear();
                DisplayPetStatus();
                DisplayActionMenu();
            }

            Console.Clear();
            Console.WriteLine("Your pet is died");
            string answer = Console.ReadLine();

                       


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
