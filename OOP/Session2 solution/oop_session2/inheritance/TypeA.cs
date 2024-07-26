using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_session2.inheritance
{
    internal class TypeA
    {
        public int A { get; set; }
        public TypeA(int a) {A = a; }
        public void Fn1() { Console.WriteLine("Function 1  from TypeA"); }
        public virtual void Fn2() { Console.WriteLine($"A: {A}"); }
    }
}
