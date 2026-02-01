using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_c_
{
    internal class Employee
    {
      protected  int Id { get; set; }
      protected  string Name { get; set; }
     protected   int BaseSalary { get; set; }
       public Employee() { }
        public Employee(int id, string name, int baseSalary)
        {
            Id = id;
            Name = name;
            BaseSalary = baseSalary;
        }

        public  void DisplayInfo()
        {
            Console.WriteLine("Name "+this.Name +" , ID: "+this.Id+" , Salary: "+this.BaseSalary);
        }
        public virtual int CalcSalary() { 
            return this.BaseSalary;
        }

    }
}
