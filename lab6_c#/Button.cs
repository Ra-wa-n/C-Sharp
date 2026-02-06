using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_c_
{
    
    internal class Button
    {
        public event Action<Button,string> OnClick;
        string Name;
        public void performclick()
        {
            OnClick?.Invoke(this,Name);
        }
    }
}
