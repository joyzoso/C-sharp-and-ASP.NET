using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//C# programming tutorial - Step by Step
//Patrick WashingtonDC
//examples for personal studying

namespace exerciseB
{
    class exerciseB
    {
        static void Main()
        {
            string[] strs = { "3.45", "3.87", "87.98", "56.70" };

            double total = 0.0;

            foreach (string temp in strs)
            {
                total += Convert.ToDouble(temp);
            }
            Console.WriteLine("Total = " + total);
        }
    }

}
