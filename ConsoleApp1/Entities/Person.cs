using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    internal class Person
    {
        //Victor Rafael da Silva
        public int Id { get; set; }
        public string Name { get; set; }

        public Person()
        {

        }
        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
