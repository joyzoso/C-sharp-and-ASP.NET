using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADrillMethods
{
    public class methodOverload
    {
        public void addString(string one, string two)
        {
            Console.WriteLine(one + two);
            Console.ReadLine();
        }
        public void addString(string one, string two, string three)
        {
            Console.WriteLine(one + two + three);
            Console.ReadLine();            
        }
    }
}
