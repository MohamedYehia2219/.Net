using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_Assignment1
{
    internal struct Point
    {
        public float X { get; set; }
        public float Y { get; set; }

        public double calcDistance(Point p)
        {
            return Math.Sqrt(Math.Pow(this.X - p.X, 2) + Math.Pow(this.Y - p.Y, 2));
        }
    }
}
