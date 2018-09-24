using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter in an animal type");
            string Type = Console.ReadLine(); 
            Console.WriteLine("Please enter in the sound the animal makes");
            string Sound = Console.ReadLine();

            Animal animal1 = new Animal(Type, Sound);

            Console.WriteLine(animal1.AnimalSays());


            Console.ReadLine();
        }

        class Animal
        {

            //Private properties
            private string type;
            private string sound;

            //prop then push tab twice to create a new getter and setter
           

            //Public getters and setters
            public string Type { get { return type; } set { type = value; } }
            public string Sound { get { return sound; } set { sound = value; } }

            //Public constructor
            public Animal(string _type, string _sound)
            {
                Type = _type;
                Sound = _sound;
            }

            //Public method
            public string AnimalSays()
            {
                return "The " + Type + " says " + Sound; 
            }
        }
    }
}
