using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeB
    {
        void fn()
        {
            TypeA typeA = new TypeA();
            TypeB typeB = new TypeB();
            //  typeA.x = 1;        Invalid as the private access modifiers
            typeA.y = 1;
            typeA.z = 2;
        }
    }
}
