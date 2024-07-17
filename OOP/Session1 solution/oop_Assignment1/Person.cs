using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_Assignment1
{
    internal struct Person
    {
        private string name;
        private int age;
        public Person(int age, string name)
        {
            Age = age;
            Name = name;
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Name 
        {
            get { return name; }
            set
            {
                if (value != "" && value != null)
                    name = value;
                else name = "no name";
            }
        }
    }
}
