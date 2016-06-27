using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace VirtualPet
{
    class Program
    {
        static VirtualPet MyPet = new VirtualPet();

        static void Main(string[] args)
        {
            // define pet type
            // loop every minute and interrupt when there is keyboard input
            // end when you sell the pet

            string petsName;
            string petType;
            int numberOfLegs;
            int weight;
            bool tail = false;

            string answer;

            Console.Clear();
            Console.WriteLine("Create Your Virtual Pet");
            Console.WriteLine();
            Console.Write("What is your pet's name : ");
            petsName = Console.ReadLine();

            Console.Write("What is your animal type : ");
            petType = Console.ReadLine();

            Console.Write("Number of legs : ");
            numberOfLegs = Convert.ToInt32(Console.ReadLine());

            Console.Write("Weight of your pet : ");
            weight = Convert.ToInt32(Console.ReadLine());

            Console.Write("Does your pet have a tail : ");
            answer = Console.ReadLine();

            if (answer.ToLower() == "yes")
            {
                tail = true;
            }

        /*    if (tail)
            {
                Console.WriteLine("Your pet, {0}, a {1}, weighing {2} pounds with {3} legs and a tail has been created.", petsName, petType, weight, numberOfLegs);
            }
            else
            {
                Console.WriteLine("Your pet, {0}, a {1}, weighing {2} pounds with {3} legs has been created.", petsName, petType, weight, numberOfLegs);
            }


            Console.WriteLine("Press any key to interact with your pet");
            Console.ReadLine();
            */

            Console.Clear();
            MyPet.Name = petsName;
            MyPet.AnimalType = petType;
            MyPet.NumberOfLegs = numberOfLegs;
            MyPet.Weight = weight;
            MyPet.Tail = tail;

            int menuOption = 0;
            
            Thread thread = new Thread(MyPet.RunTick);
            thread.Start();


            while (!MyPet.ReachedTheLimit())
            {
                // get pet status
                Console.Clear();
                MyPet.DisplayPetStatus();                
                MyPet.DisplayActionMenu();

             
                answer = Console.ReadLine();
                menuOption = Convert.ToInt32(answer);

                switch (menuOption)
                {
                    case 1:
                        MyPet.FeedPet();
                        break;
                    case 2:
                        MyPet.WaterPet();
                        break;
                    case 3:
                        MyPet.PeeBreak();
                        break;
                    case 4:
                        MyPet.PoopBreak();
                        break;
                    case 5:
                        MyPet.NapTime();
                        break;
                    case 6:
                        MyPet.PlayTime();
                        break;
                    case 7:
                        Console.WriteLine("Return pet");
                        MyPet.Tiredness = 101;
                        break;
                    default:
                        Console.WriteLine("Choose a valid option");
                        break;

                }
               

            }


           // Console.WriteLine("After while loop");





        }
    }
}
