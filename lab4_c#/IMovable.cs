using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_c_
{
    internal interface IMovable
    {
        void Move();
        void Stop();
        int GetSpeed();
    }
}
