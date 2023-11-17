using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMethods
{
    internal static class ArrayHelper
    {
        public static void IterateAndPrint(int[] ints)
        {
            IterateAndPrint(ints, 0);
        }
        
        private static void IterateAndPrint(int[] ints, int index)
        {
            if (ints == null || ints.Length == 0)
            {
                return;
            }

            if (index > -1 && index < ints.Length) 
            {
                Console.WriteLine(ints[index]);
                if(index < ints.Length - 1)
                {
                    IterateAndPrint(ints, ++index);
                }
            }
            
        }
    }
}
