using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] numbers = new int[5];

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;
            numbers[5] = 42;
            */
            /*
            int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };

            Console.WriteLine(numbers[1].ToString());
            Console.ReadLine();
            */

            /*string[] names = new string[] { "Eddie", "Alex", "Mike", "Larry" };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();*/

            string zig = "la la la la la laljklkjlsjd " +
                "definitely invalid expression.";
           
            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
                Console.Write(zigChar);

            Console.ReadLine();
        }
    }
}
