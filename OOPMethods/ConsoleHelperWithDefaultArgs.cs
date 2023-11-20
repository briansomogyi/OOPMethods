using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMethods
{
    internal static class ConsoleHelperWithDefaultArgs
    {
        public static void PrintMessage(string message, string label = "", int count = 1)
        {
            if (count > 0)
            {
                string formattedLabel = string.Empty;
                if (!string.IsNullOrWhiteSpace(label))
                {
                    formattedLabel = $"{label}: ";
                }

                Console.Write(formattedLabel);
                for (int i = 0; i < count; i++)
                {
                    Console.Write($"{message} ");
                }

                Console.WriteLine();
            }
        }
    }
}
