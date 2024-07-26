using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Common
{
    public class TypeB:TypeA
    {
        public void fun()
        {
            /* with out inheritance (protected means nothing)
            TypeA obj = new TypeA();
            obj.x = 5;    //[Invalid] [private]
            obj.y = 6;    //[Invalid] [private]
            obj.z = 7;    //[valid]   [internal] --> project scope
            obj.m = 8;    //[Invalid] [private]
            */

            // with inheritance
            x = 0;  // x is protected private  --> inherited as private
            y = 0;  // y is protected          --> inherited as private
            z = 0;  // z is protected internal --> inherited as [internal]
            //m = 0;  // [Invalid] [not inherite as private access modifier]
        }
    }
}
