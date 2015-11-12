using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADrillMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling the overriden derived method
            methodOverride2 funobject = new methodOverride2();
            funobject.Example();

            //calling the base class method
            methodOverride anotherfunobject = new methodOverride2();
            anotherfunobject.Example();
        }
    }
}
