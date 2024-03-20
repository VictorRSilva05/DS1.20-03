using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    internal class Worker : Person
    {
        //Victor Rafael da Silva
        public float Salary { get; set; }

        public Worker() { }
        public Worker(int id, string name, float salary) : base(id, name)
        {
            Salary = salary;
        }

    }
}
