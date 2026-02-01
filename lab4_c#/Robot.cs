using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_c_
{
    internal class Robot :IMovable,IChargeable
    {
        int speed {  get; set; }
        int battery { get; set; } = 100;

        public void Move()
        {
            speed = 10;
            battery -= 10;
            Console.WriteLine("Robot is walking");
        }

        public void Stop()
        {
            speed = 0;
            Console.WriteLine("Robot stopped");
        }

        public int GetSpeed()
        {
            return speed;
        }

        public void Charge()
        {
            battery = 100;
            Console.WriteLine("Robot is charging");
        }

        public int GetBatteryLevel()
        {
            return battery;
        }
    }
}
