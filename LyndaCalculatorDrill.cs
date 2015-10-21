using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Exercise
{
    class Program
    {

        static void Main(string[] args)
        {

            int Value1 = getValue("Hello, please enter a value");
            int Value2 = getValue("enter another one");

            int result = 0;

            while (true)
            {
                Console.WriteLine("Do you want to (A)dd, (S)ubtract, (M)Mulitply or (D)ivide these numbers?");

                // allows user to input a single key and return it
                ConsoleKeyInfo info = Console.ReadKey();
                string operation = info.Key.ToString();

                //upper case to add flexibility for user
                switch (operation.ToUpper())
                {
                    case "A":
                        result = add(Value1, Value2);
                        break;
                    case "S":
                        result = subtract(Value1, Value2);
                        break;
                    case "M":
                        result = multiply(Value1, Value2);
                        break;
                    case "D":
                        result = divide(Value1, Value2);
                        break;
                    default:
                        Console.WriteLine("Choose from the listed ops");
                        continue;
                }

                Console.WriteLine("\nResult: " + result);
                Console.Read();
                break;
            }

        }

            
            private static int getValue(string label)

        {
            int value;

            while (true)
            {
                Console.WriteLine(label);
                string input = Console.ReadLine();
                if (int.TryParse(input, out value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Not a valid value");
                }
            }
        }

        private static int add(int Value1, int Value2)
        {
            return Value1 + Value2;
        }
        private static int subtract(int Value1, int Value2)
        {
            return Value1 - Value2;
        }
        private static int multiply(int Value1, int Value2)
        {
            return Value1 * Value2;
        }
        private static int divide(int Value1, int Value2)
        {
            if (Value1 == 0 || Value2 == 0)
            {
                return 0;
            }
            else
            {
                return Value1 / Value2;
            }
        }
    }
}
