using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_c_
{
    internal class Student
    {
        int age;
     public   string Name {  get; set; }  
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 16 && value <= 100)
                    age = value;
                else
                    age = 0;
            }
        }
        public Student(int age,string name) { 
            this.age = age;
            this.Name = name;
        }

        public Student() { }


    }
}
