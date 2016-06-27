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

            Console.Write("Number of legs (1 - 4): ");
            numberOfLegs = Convert.ToInt32(Console.ReadLine());
            if (numberOfLegs < 1)
            {
                numberOfLegs = 1;
            }
            else if (numberOfLegs > 4)
            {
                numberOfLegs = 4;
            }

            Console.Write("Weight of your pet (limit 100 lbs): ");
            weight = Convert.ToInt32(Console.ReadLine());

            Console.Write("Does your pet have a tail (yes or no) : ");
            answer = Console.ReadLine();

            if (answer.ToLower() == "yes")
            {
                tail = true;
            }

            Console.WriteLine("Please enter into full screen mode - press any key to continue");
            Console.ReadKey();



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
                if (MyPet.ReachedTheLimit())
                {
                    break;
                }
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
                        Console.Write("You chose to return your pet - are you sure ? (yes or no)");
                        answer = Console.ReadLine();
                        if (answer.ToLower() == "yes")
                        {
                            Console.WriteLine("Your pet is being returned - Press any key to end program!");
                            Console.ReadLine();
                            MyPet.Tiredness = 101;
                        }
                        break;
                    default:
                        Console.WriteLine("Choose a valid option");
                        break;

                }

            }
            if (menuOption != 7)
            {
                Console.Clear();
                Console.WriteLine("Your pet is died  - press any key to end program.");
                answer = Console.ReadLine();
            }


        }
    }
}
