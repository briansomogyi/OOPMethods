using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMethods
{
    internal static class ConsoleHelper
    {
        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static void PrintMessage(string label, string message) 
        {
            if (!string.IsNullOrEmpty(label)) 
            {
                Console.WriteLine($"{label}: ");
            }
            Console.WriteLine($"{message}");
        }

        public static void PrintMessage(string message, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(message);
            }
        }
    }
}
