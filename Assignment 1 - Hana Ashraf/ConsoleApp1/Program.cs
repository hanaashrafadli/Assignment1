namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name ?");
            string Name = Console.ReadLine();
            Console.WriteLine($"hello, {Name} Welcome to C# course.");
            // simple greeting program.



            Console.WriteLine("please enter two numbers");
            double number1 = double.Parse(Console.ReadLine()), number2 = double.Parse(Console.ReadLine());
            double sum = number1 + number2;
            double substract = number1 - number2;
            double multiblication = number2 * number1;
            double devision = number1 / number2;
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Difference = {substract}");
            Console.WriteLine($"Product = {multiblication}");
            // Basic arethmatic operations.



            Console.WriteLine("please enter your bith year");
            int birthDate = int.Parse(Console.ReadLine());
            int age = 2024 - birthDate;
            Console.WriteLine($"you are {age} years old");
            //age calculater


            Console.WriteLine("please enter the tempreture in Celsius");
             double celsiusTemp = double.Parse(Console.ReadLine());
             double fahranheitTemp = (celsiusTemp * 9/5) + 32;
            Console.WriteLine($"{celsiusTemp} degree in Celsius is {fahranheitTemp} degrees Fahrenheit");
            //tempreture converter
        }
    }
}
