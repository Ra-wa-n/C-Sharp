using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_c_
{
    internal class Dog:Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof! Woof!");
        }

        public override void Move()
        {
            Console.WriteLine("Running on four legs!");
        }
    }
}
