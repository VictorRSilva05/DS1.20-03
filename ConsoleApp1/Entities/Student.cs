using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    internal class Student : Person
    {
        //Victor Rafael da Silva
        public string Course { get; set; }
        public Student(int id, string name, string course) : base(id, name)
        {
            Course = course;
        }
    }
}
