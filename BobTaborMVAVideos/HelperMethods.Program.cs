using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // string myValue = secretFormula("Joy");
            string myValue = secretFormula("Sunshine");
            Console.WriteLine(myValue);
            Console.ReadLine();
        }

        private static string secretFormula()
        {
            //stuff here
            return "Hello";
        }

        private static string secretFormula(string name)
        {
            return string.Format("Hello, {0}!", name);
        }

    }
}
