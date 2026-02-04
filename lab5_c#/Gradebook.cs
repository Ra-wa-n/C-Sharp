using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_c_
{
    internal class Gradebook
    {
        public int[] Grades { get; set; }
        public int this[int index]{
            get
            {
                return Grades[index];
            }
            set
            {
                Grades[index] = value;
            }
            }
    }
}
