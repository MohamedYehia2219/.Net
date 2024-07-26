using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_session2.inheritance
{
    internal class TypeB:TypeA
    {
        public int B { get; set; }
        public TypeB(int a, int b) : base(a)
        { 
            B = b; 
        }
        public new void Fn1() { Console.WriteLine("Function 1  from TypeB"); }
        public override void Fn2() { Console.WriteLine($"A: {A}, B: {B}"); }
    }
}
