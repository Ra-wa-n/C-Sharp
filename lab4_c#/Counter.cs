using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_c_
{
    internal class Counter
    {
    public   static int counter ;
     static Counter()
        {
            counter=0;
        }
        public Counter()
        {
           ++ counter;
        }
    }
}
