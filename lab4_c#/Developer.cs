using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_c_
{
    internal class Developer:Employee
    {
            string Language { get; set; }
            int Projects {  get; set; }

            public Developer(int id, string name, int salary, string language, int projects)
                : base(id, name, salary)
            {
                this.Language = language;
                this.Projects = projects;
            }
        public void DisplayDevInfo()
        {
            Console.WriteLine("Name " + this.Name + " , ID: " + this.Id + " , Salary: " + this.BaseSalary + " , language:" + this.Language + " , projects: " + this.Projects);
        }
        }

    }

