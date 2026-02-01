using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_c_
{
    abstract class Animal
    {
        public abstract void MakeSound();
        public abstract void  Move();
        public void Sleep()
        {
            Console.WriteLine("Animal is sleeping...");
        }
    }
}
