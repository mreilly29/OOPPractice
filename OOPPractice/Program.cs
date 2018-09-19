using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            ////USING DOG CLASS
            //Dog woofy = new Dog();
            //Dog spot = new Dog();
            //Dog woofy = new Dog(7, 8.5, 33.2, 190.1, "Woofy");
            //Dog spot = new Dog(15, 10.5, 100.9, 250.3, "Spot");
            //Console.WriteLine("woofy's hair length is: {0}", woofy.HairLength);
            //Console.WriteLine("spot's hair length is: {0}", spot.HairLength);
            //woofy.HairLength = 4;
            //spot.HairLength = 6;
            //woofy.GetSpeed(7);
            //spot.GetSpeed(11);
            //Console.WriteLine("woofy's hair length is: {0}", woofy.HairLength);
            //Console.WriteLine("spot's hair length is: {0}", spot.HairLength);
            //Console.WriteLine("woofy is running {0}", woofy.GetSpeed(7));

            //USING HEROES CLASS
            Heroes maggie = new Heroes("Maggie");

            Console.WriteLine("Hello {0}. Right now your strength is {1} and your bike speed is {2}.", maggie.Name, maggie.Strength, maggie.BikeSpeed);

            Console.WriteLine("Would you like to check your health {0}?", maggie.Name);
            if (Console.ReadLine().ToLower() == "yes")
            {
                maggie.GetHealth();
            }
           

            Console.WriteLine("Do you have a cape {0}?", maggie.Name);
            if (Console.ReadLine().ToLower() == "yes")
            {
                maggie.IsCool(true);
            }
            else
            {
                maggie.IsCool(false);
            }

            Console.WriteLine("Are you in danger {0}?", maggie.Name);
            if (Console.ReadLine().ToLower() == "yes")
            {
                maggie.GetHelp();
            }

            Console.WriteLine("Your strength is: {0}", maggie.Strength);
            Console.WriteLine("Your bike speed is: {0}", maggie.BikeSpeed);


        }//Main
    }//class Program
}//namespace OOPPractice
