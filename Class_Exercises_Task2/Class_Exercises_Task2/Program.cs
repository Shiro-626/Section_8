using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Exercises_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task2 - Person first name, last name, age

            Person p1 = new Person("Miku", "Hatsune", 20);

            Console.WriteLine("Person one: "+p1.Fname + " " + p1.Lname + " " + p1.Age );
            Console.ReadLine();
        }

        class Person
        {
            public string fname;
            public string lname;
            private int age;

            public string Fname { get { return fname; } set { fname = value; } }
            public string Lname { get { return lname; } set { lname = value; } }
            public int Age { get { return age; } set { age = value; } }

            public Person(string _fname, string _lname, int _age)
            {
                Fname = _fname;
                Lname = _lname;
                Age = _age;
            }

        }

        


    }
}
