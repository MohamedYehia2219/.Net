using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_session2
{
    internal class Test:Common.TypeA
    {
        public void fun()
        {
            //x = 0;    [Invalid] as x is protected private  --> [cannot be inherited outside project]
            y = 0;      // y is protected          --> inherited as private
            z = 0;      // z is protected internal --> inherited as private outside project
            //m = 0;    [Invalid] [not inherited]
        }
    }
}
