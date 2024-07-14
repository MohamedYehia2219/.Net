using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_session1
{
    internal struct point
    {
        internal int x;
        internal int y;

        // default constructor
        /*public point()
        {
            x = default;
            y = default;
        }*/

        // parameterless constructor 
        // override the default constructor
        // from c#10 .Net6
        public point()
        {
            x = 10;
            y = 10;
        }

        //parameterized constructor
        public point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"x = {this.x}   y = {y} ";
        }

    }
}
