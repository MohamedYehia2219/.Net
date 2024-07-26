using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_session2.inheritance
{
    internal class Child:Parent
    {
        //Error: because the child default constructor tried to [chain][call] the default constructor of the parent calss.
        //Solution: create default constructor in the parent
        //          or make the child constructor chainning the user defined constructor in the parent.

        public int y;

        public Child(int y, int x, int a, int b):base(x, a, b)      //External constructor chainning
        { this.y = y; }

        public new void fn1() { Console.WriteLine("Iam child class"); }
    }
}
