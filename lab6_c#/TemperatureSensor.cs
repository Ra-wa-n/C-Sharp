using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_c_
{
    internal class TemperatureSensor

    {
        public event Action<string ,double> SensorChanged;
        double temp;
        public void SetTemp(double temp)
        {
            if (temp < -1)
            {
                SensorChanged?.Invoke("cloudy",temp);
            }
        }

    }
}
