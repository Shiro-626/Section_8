using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter in the employees first name");
            string Fname = Console.ReadLine();
            Console.WriteLine("Please enter in the employees last name");
            string Lname = Console.ReadLine();
            Console.WriteLine("Please enter in the employees annual gross income");
            decimal Grossincome = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please enter in the tax rate");
            decimal Taxrate = decimal.Parse(Console.ReadLine());

            Employee employee1 = new Employee(Fname, Lname, Grossincome, Taxrate);

            Console.WriteLine("The employees name is: " + employee1.Fname + " " + employee1.Lname + ". Their gross income and tax rate is: " + employee1.Grossincome + " , "+ employee1.Taxrate);
            Console.WriteLine("The net salary is: " + employee1.NetSalary());

            Console.ReadLine();

        }

        
        class Employee
        {
            //Private properties
            string fname;
            string lname;
            decimal grossincome;
            decimal taxrate;


            //Public getters and setters
            public string Fname { get { return fname; } set {fname = value; } }
            public string Lname { get { return lname; } set { lname = value; } }
            public decimal Grossincome { get {return grossincome; } set {grossincome = value; } }
            public decimal Taxrate { get { return taxrate; } set { taxrate = value; } }


            //Public constructor
            public Employee(string _fname, string _lname, decimal _grossincome, decimal _taxrate)
            {
                Fname = _fname;
                Lname = _lname;
                Grossincome = _grossincome;
                Taxrate = _taxrate;
            }

            //Public method
            public decimal NetSalary()
            {
               
                return Math.Round((Grossincome * (1 - (Taxrate/100))),2);
            }

        }
    }
}
