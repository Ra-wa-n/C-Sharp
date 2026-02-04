using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_c_
{
    internal class Person
    {
       public int Id { get; set; }
        public string Name { get; set; }
        public void Print() { 
            Console.WriteLine(this.Name);
        }
    }
}
