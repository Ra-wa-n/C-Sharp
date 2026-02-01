using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_c_
{
    internal class Date
    {
        int year;
        int month;
        int day;
        public Date() : this(2003,8,8) { }
        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }
        public Date(int year,int month): this(year,month,1) { }
        public Date(int year) : this(year, 1, 1) { }
        public void PrintDate() 
        { 
            Console.WriteLine(this.day+"/"+this.month+"/"+this.year);   
        }

    }
}
