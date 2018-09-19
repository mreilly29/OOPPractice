using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class Heroes
    {
        //FIELDS
        private int strength = 100;
        private bool cape;
        private int bikeSpeed = 50;
        private int bootSize;
        private string name;

        //properties
        public int Strength
        {
            get { return this.strength; }
            set { this.strength = value; }
        }
       
        public bool Cape
        {
            get { return this.cape; }
            set { this.cape = value; }
        }

        public int BikeSpeed
        {
            get { return this.bikeSpeed; }
            set { this.bikeSpeed = value; }
        }

        public int BootSize
        {
            get { return this.bootSize; }
            set { this.bootSize = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        
        //CONSTRUCTORS
        public Heroes()
        {

        }

        public Heroes(int strong, bool cape)
        {
            this.Strength = strong;
            this.Cape = cape;
        }

        public Heroes(string person)
        {
            this.Name = person;            
        }        
       
        //METHODS
        public void GetHealth()
        {
            Strength = Strength - 10;
            Console.WriteLine("Stop checking your health! Strength minus 10.");
        }

        public void GetHelp()
        {
            Console.WriteLine("Now {0}.. I don't mean to be rude, but have you slacked with your classmates?", Name);
            if(Console.ReadLine().ToLower() == "yes")
            {
                BikeSpeed += 10;
                Console.WriteLine("Cool beans, you listened. Please Accept these 10 points for your bike speed!");
            }
            else
            {
                BikeSpeed-=20;
                Strength -= 50;
                Console.WriteLine("You're not Gucci. SLACK YOUR CLASSMATES FIRST.");
                Console.WriteLine("Bike speed minus 20. Strength minus 50.");
            }
        }

        public void IsCool (bool hasCape)
        {
            if (hasCape == true)
            {
                Strength -= 5;
                Console.WriteLine("Fool! A cape can kill you. Strength minus 5.");
            }
            else
            {
                Strength += 15;
                Console.WriteLine("Now your a smart hero. Strength plus 15.");
            }
        }

        public void EatSpinach(bool healthy)
        {
            Strength += 7;
        }
        
        

    }
}
