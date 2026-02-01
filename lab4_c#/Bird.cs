using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_c_
{
    internal class Bird:Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Tweet!");
        }

        public override void Move()
        {
            Console.WriteLine("Flying in the sky!");
        }
    }
}
