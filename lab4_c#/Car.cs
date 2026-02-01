using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_c_
{
    internal class Car:IMovable
    { 
        int speed {  get; set; }
        public void Move()
        {
            speed = 60;
            Console.WriteLine("Car is moving");
        }

        public void Stop()
        {
            speed = 0;
            Console.WriteLine("Car stopped");
        }

        public int GetSpeed()
        {
            return speed;
        }
    }
}
