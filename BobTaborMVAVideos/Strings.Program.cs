﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "Go to your c:\\ drive";
            //string myString = "My \"so called\" life";
            //string myString = "What if I need a \n a new line?";

            //string myString = string.Format("{0}!", "Bonbo");
            //string myString = string.Format("Make: {0} (Model: {1})", "BMW", "760li");

            //string myString = string.Format("{0:C}", 123.45);
            //string myString = string.Format("{0:N}", 1234546789);
            //string myString = string.Format("{0:P}", .123);
            //string myString = string.Format("Phone Number: {0:(###)###-####}", 1234567890);

            /*string myString = "";

            for (int i = 0; i < 100; i++)
            {
                //myString = myString + "--" + i.ToString();
                myString += "--" + i.ToString();
            }
            */

            /*StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }
            */
            
            string myString = " Oh let the sun beat down upon my face  ";

            //myString = myString.Substring(5,14);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--");
            myString = String.Format("Length before: {0} -- After: {1}", myString.Length, myString.Trim().Length);


            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
