using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Exercises_Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Task1 - Car make, model, colour, rego

            Car car1 = new Car();
            car1.Make = "Toyota";
            car1.Model = "Camry";
            car1.Colour = "Silver";
            car1.Rego = "TUTURU";

            Car car2 = new Car();
            car2.Make = "Holden";
            car2.Model = "Apollo";
            car2.Colour = "Red";
            car2.Rego = "H1H1H1";

            Car car3 = new Car();
            car3.Make = "Ford";
            car3.Model = "GT";
            car3.Colour = "Blue";
            car3.Rego = "N00T12";

            Car car4 = new Car();
            car4.Make = "Nissan";
            car4.Model = "Armada";
            car4.Colour = "Green";
            car4.Rego = "N00T21";

            Car car5 = new Car();
            car5.Make = "BMW";
            car5.Model = "X1";
            car5.Colour = "Black";
            car5.Rego = "W41FU3";

            
            Console.WriteLine("Car one properties are: "+ car1.Make + " " + car1.Model + " " + car1.Colour + " " + car1.Rego);
            Console.WriteLine("Car two properties are: "+ car2.Make + " " + car2.Model + " " + car2.Colour + " " + car2.Rego);
            Console.WriteLine("Car three properties are: "+ car3.Make + " " + car3.Model + " " + car3.Colour + " " + car3.Rego);
            Console.WriteLine("Car four properties are: "+ car4.Make + " " + car4.Model + " " + car4.Colour + " " + car4.Rego);
            Console.WriteLine("Car five properties are: "+ car5.Make + " " + car5.Model + " " + car5.Colour + " " + car5.Rego);

            Console.ReadLine();

            /*
             int[] nums = new int[5]
             Car[] carCollection = new Car[5]
             
             */
        }
    }

    class Car
    {
        string make;
        string model;
        string colour;
        string rego;

        public string Make { get { return make; } set { make = value; } }
        public string Model { get { return model; } set { model = value; } }
        public string Colour { get { return colour; } set { colour = value; } }
        public string Rego { get { return rego; } set { rego = value; } }
    }


}
