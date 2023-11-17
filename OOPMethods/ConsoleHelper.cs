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
            PrintMessage(string.Empty, message, 1);
        }

        public static void PrintMessage(string label, string message) 
        {
            PrintMessage(label, message, 1);
        }

        public static void PrintMessage(string message, int count)
        {
            PrintMessage(string.Empty, message, count);
        }

        public static void PrintMessage(string label, string message, int count)
        {
            if (!string.IsNullOrEmpty(label))
            {
                Console.Write($"{label}: ");
            }
            
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(message);
            }
        }
    }
}
