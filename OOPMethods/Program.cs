namespace OOPMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.PrintMessage("test");
            
            ConsoleHelper.PrintMessage("lable", "test");
            
            ConsoleHelper.PrintMessage("test", 3);

            Console.WriteLine(MathHelper.Factorial(5));

            int[] ints = {1,2, 3, 4, 5};
            ArrayHelper.IterateAndPrint(ints);
        }
    }
}