using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMethods
{
    internal static class MathHelper
    {
        public static int Factorial(int x)
        {
            if (x < 0)
            {
                throw new ArgumentException("You must specify a positive numeric vallue.");
            }

            if (x < 2)
            {
                return 1;
            }

            int v = Factorial(x - 1);
            return x * v;
        }
    }
}
