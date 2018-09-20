using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Exercises_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task3 - Animal types, names, id number

            Animal animal1 = new Animal("Platypus", "Perry");

            Console.WriteLine("Animal 1: "+animal1.Type + " " + animal1.Name + " " + animal1.Idnumber );
            Console.ReadLine();
            
        }

        class Animal
        {
            string type;
            string name;
            int idnumber;

            public string Type { get { return type; } set { type = value; } }
            public string Name { get { return name; } set { name = value; } }
            public int Idnumber { get { return idnumber; } set { idnumber = value; } }

            public Animal(string _type, string _name)
            {
                Type = _type;
                Name = _name;
                Idnumber = Rand();
            }

            public string GetFullDetails()
            {
                return Type + " " + Name + " " + Idnumber;
            }

            public int Rand()
            {
                Random rnd = new Random();
                int idnumber = rnd.Next(1, 9999);
                return idnumber;
            }

        }
        
    }
}
