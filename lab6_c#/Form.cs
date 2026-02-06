using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_c_
{
    internal class Form
    {
        public void OnClick(Button sender, string buttonName)
        {
            Console.WriteLine($"FormHandler: {buttonName} clicked!");
        }
    }
    class Logger
    {
        public void LogClick(object sender, string buttonName)
        {
            Console.WriteLine($"Logger: {buttonName} click logged.");
        }
    }
}
