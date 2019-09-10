using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "";
            string Contact = "";
            string Address = "";
            int Age;

            Console.WriteLine("Your Name?");
            Name = Console.ReadLine();

            Console.WriteLine( "What is your Age?  " );
            Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your Contact Number?  ");
            Contact = Console.ReadLine();

            Console.WriteLine("Address? ");
            Address = Console.ReadLine();

            Console.WriteLine("My Name : " + Name);
            Console.WriteLine("My Age : " +Age);
            Console.WriteLine("My Phone Number :" + Contact);
            Console.WriteLine("My Address :" + Address);

            Console.ReadLine();

        }
    }
}
