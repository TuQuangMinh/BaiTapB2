using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class student
    {
        //datamember
        public int id;
        public string name;
        public int age;

        //properti
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        
        public student(int id, string name, int age)
        {
            Id = id;
            Name = name;    
            Age = age;
        }

        public override string ToString()
        {
            return $"{Id}, Name: {Name}, Age: {Age}";
        }
    }
}

