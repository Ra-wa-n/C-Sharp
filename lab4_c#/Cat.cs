using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_c_
{
    internal class Cat:Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }

        public override void Move()
        {
            Console.WriteLine("Walking quietly!");
        }
    }
}
