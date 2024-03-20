using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    internal class Teacher : Worker
    {
        //Victor Rafael da Silva
        public Teacher() { }
        public Teacher(int id, string name, float salary) : base(id, name, salary)
        {
        }

    }
}
