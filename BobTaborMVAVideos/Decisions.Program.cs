using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Pleas type something and press enter");
            //string userValue;
            //userValue = Console.ReadLine();
            //Console.WriteLine("You typed: " + userValue);

            Console.WriteLine("Would you prefer door 1, 2 or 3?");
            string userValue = Console.ReadLine();

            //string message = "";

            //if (userValue == "1")

            //    message = "you got new car";
            //else if (userValue == "2")
            //    message = "yay";
            //else if (userValue == "3")
            //    message = "threee!!!";
            //else
            //    message = "sorry you dummy";


            string message = (userValue == "1") ? "boat" : "Strand og lint";
          
            Console.WriteLine("You won a {0}", message);
            Console.ReadLine();
        }
    }
}
