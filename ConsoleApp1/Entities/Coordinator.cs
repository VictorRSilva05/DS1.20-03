using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    internal class Coordinator : Worker
    {
        //Victor Rafael da Silva
        public string Course { get; set; }

        public Coordinator() { }
        public Coordinator(int id, string name,float salary, string course) : base(id, name, salary)
        {
            Course = course;
        }

    }
}
