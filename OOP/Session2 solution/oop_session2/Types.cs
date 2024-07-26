using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_session2
{
    internal class TypeA
    {
        public int A { get; set; }
        public TypeA(int a) { A = a; }
        public void fun1() { Console.WriteLine("Type A"); }
        public virtual void fun2() { Console.WriteLine($"{A}"); }
    }
    internal class TypeB:TypeA
    {
        public int B { get; set; }
        public TypeB(int a,int b):base(a) { B=b; }
        public new void fun1() { Console.WriteLine("Type B"); }
        public override void fun2() { Console.WriteLine($"{A}, {B}"); }
    }
    internal class TypeC : TypeB
    {
        public int C { get; set; }
        public TypeC(int a, int b, int c) : base(a,b) { C = c; }
        public new void fun1() { Console.WriteLine("Type C"); }
        public override void fun2() { Console.WriteLine($"{A}, {B}, {C}"); }
    }
    internal class TypeD : TypeC
    {
        public int D { get; set; }
        public TypeD(int a, int b, int c, int d) : base(a, b, c) { D = d; }
        public new void fun1() { Console.WriteLine("Type D"); }

        //public override void fun2() { Console.WriteLine($"{A}, {B}, {C}, {D}"); }
        public virtual new void fun2() { Console.WriteLine($"{A}, {B}, {C}, {D}"); }
    }
    internal class TypeE : TypeD
    {
        public int E { get; set; }
        public TypeE(int a, int b, int c, int d, int e) : base(a, b, c, d) { E = e; }
        public new void fun1() { Console.WriteLine("Type E"); }
        public override void fun2() { Console.WriteLine($"{A}, {B}, {C}, {D}, {E}"); }

        //public new void fun2() { Console.WriteLine($"{A}, {B}, {C}, {D}, {E}"); }
    }

}
