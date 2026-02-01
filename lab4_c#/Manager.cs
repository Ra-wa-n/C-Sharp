using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_c_
{
    internal class Manager:Employee
    {
        int Bonus { get; set; }
        int Timesize { get; set; }
        public Manager(int id ,string name,int salary,int bouns,int time) : base(id, name, salary) {

            this.Bonus = bouns;
            this.Timesize = time;
        }
        public override int CalcSalary()
        {
            return BaseSalary+Bonus;
        }
        public void DisplayMangerInfo()
        {
            Console.WriteLine("Name " + this.Name + " , ID: " + this.Id + " , Salary: " + this.BaseSalary + " , Bonus:" + this.Bonus + " , Time:" + this.Timesize);
        }
    }
}
