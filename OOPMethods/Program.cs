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

            ConsoleHelperWithDefaultArgs.PrintMessage("test");
            ConsoleHelperWithDefaultArgs.PrintMessage("message", "label");
            ConsoleHelperWithDefaultArgs.PrintMessage("message", "label", 3);

            Console.WriteLine($"Price: {PriceCalculator.CalculatePrice(unitPrice: 10)}");
            Console.WriteLine($"Price: {PriceCalculator.CalculatePrice(unitPrice: 15, quantity: 3)}");
            Console.WriteLine($"Price: {PriceCalculator.CalculatePrice(unitPrice: 20, quantity: 5, vatPercent: 9)}");

            // Mixing positional arguments with named arguments
            Console.WriteLine($"Price: {PriceCalculator.CalculatePrice(20, vatPercent: 9)}");

            // Named-arguments allow skipping parameters
            Console.WriteLine($"Price: {PriceCalculator.CalculatePrice(unitPrice: 20, vatPercent: 9)}");

            // or even changing the parameters order
            Console.WriteLine($"Price: {PriceCalculator.CalculatePrice(vatPercent: 9, quantity: 5, unitPrice: 20)}");

            int result = 10;
            Console.WriteLine($"Before increment: {result}");
            Increment(ref result);
            Console.WriteLine($"After increment: {result}");

            string? numberAsString = Console.ReadLine();
            int.TryParse(numberAsString, out result);
            IncrementWithOut(result, out result);
            Console.WriteLine(result);

            Point point = new Point();
            point = new Point()
            {
                X = 100,
                Y = 100,
            };
            Rectangle rectangle = new Rectangle(new Point(100, 100), 50, 70);

            Person person = new Person("John", "Doe");
            
            Console.WriteLine($"Before calling SayHello: {person.FirstName} {person.LastName}");
            SayHello(ref person);
            Console.WriteLine($"After calling SayHello: {person.FirstName} {person.LastName}");

            person = new Person("John", "Doe");
            
            Console.WriteLine($"Before calling SayHello2: {person.FirstName} {person.LastName}");
            SayHello2(ref person);
            Console.WriteLine($"After calling SayHello2: {person.FirstName} {person.LastName}");

            person = new Person();
            person.FirstName = "John";
            person.LastName = "Doe";
            person.DateOfBirth = DateTime.Now;

            person = new Person()
            {
                FirstName = "John",
                LastName = "Doe",
                DateOfBirth = DateTime.Now,
            };

            person = new()
            {
                FirstName = "John",
                LastName = "Doe",
                DateOfBirth = DateTime.Now,
            };

            person = new Person("John", "Doe")
            {
                DateOfBirth = DateTime.Now,
            };
        }

        private static void Increment(ref int value)
        {
            Console.WriteLine($"Before increment: {value}");
            value++;
            Console.WriteLine($"After increment: {value}");
        }

        private static void SayHello(ref Person person)
        { 
            Console.WriteLine($"Before SayHello change: {person.FirstName} {person.LastName}");
            person.LastName = "Changed";
            Console.WriteLine($"After SayHello change: {person.FirstName} {person.LastName}");
        }

        private static void SayHello2(ref Person person)
        {
            Console.WriteLine($"Before SayHello2 change: {person.FirstName} {person.LastName}");
            person = new Person("John", "Changed");
            Console.WriteLine($"After SayHello2 change: {person.FirstName} {person.LastName}");
        }

        private static void IncrementWithOut(int prevValue,out int afterIncrementValue)
        {
            Console.WriteLine($"Before increment: {prevValue}");
            afterIncrementValue = prevValue + 1;
            Console.WriteLine($"After increment: {afterIncrementValue}");
        }
    }
}