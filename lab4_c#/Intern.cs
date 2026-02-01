using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_c_
{
    internal class Intern:Employee
    {
       
            string University { get; set; }
            int Duration {  get; set; }

            public Intern(int id, string name, int salary, string university, int duration)
                : base(id, name, salary)
            {
                this.University = university;
                this.Duration = duration;
            }
        public void DisplayInternInfo()
        {
            Console.WriteLine(
                "Name: " + this.Name +
                " , ID: " + this.Id +
                " , Salary: " + this.BaseSalary +
                " , University: " + this.University +
                " , Duration: " + this.Duration
            );
        }

    }

}
