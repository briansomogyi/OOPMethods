using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMethods
{
    internal static class ConsoleHelper
    {
        /// <summary>
        /// Prints a message on the screen
        /// </summary>
        /// <param name="message">The message to print</param>
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
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    string formattedLabel = string.Empty;
                    if (!string.IsNullOrWhiteSpace(label))
                    {
                        formattedLabel = $"{label}: ";
                    }

                    Console.WriteLine($"{formattedLabel}{message}");
                }
            }
        }
    }
}
