using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_session2.inheritance
{
    internal class Parent
    {
        public int x;
        private int a;
        internal int b;
        public Parent(int x, int a, int b)
        { 
            this.x = x;
            this.a = a;
            this.b = b;
        }

        public void fn1() { Console.WriteLine("Iam parent class"); }
        public void fn2() { Console.WriteLine($"X: {x}, A: {a}, B: {b}"); }
    }
}
