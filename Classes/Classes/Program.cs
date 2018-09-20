using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person("Pingu", "Noot noot");

            Console.WriteLine(p1.GetFullName());
            Console.ReadLine();
        }

        class Person
        {
            string fname;
            string lname;
            public string Fname { get { return fname; } set { fname = value; } }
            public string Lname { get { return lname; } set { lname = value; } }

            public Person(string _fname, string _lname)
            {
                Fname = _fname;
                Lname = _lname;
            }

            public string GetFullName()
            {
                return Fname + " " + Lname; 
            }

        }

    }
}
