using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADrillMethods
{
    public class methodOverride
    {
        public virtual void Example()
        {
            Console.WriteLine("This is the base class");
        }
    }
    //creating a derived class
    public class methodOverride2 : methodOverride
    {
        public override void Example()
        {
            Console.WriteLine("This is the derived class");
        }

    }
}
   


    

