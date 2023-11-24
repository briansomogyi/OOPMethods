using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMethods
{
    internal class Point
    {
        public Point(int x = 0, int y = 0)
        {
            X = x;
            Y = y;
        }

        public int X {  get; }
        public int Y { get; }
    }
}
