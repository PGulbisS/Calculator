using System;

namespace calculatordemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello I am console app Calculator");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Type here the first number");
            double firstnum = double.Parse(Console.ReadLine());
            Console.WriteLine("Type here the second number");
            double secondnum = double.Parse(Console.ReadLine());
            Console.WriteLine("Choose an option");
            Console.WriteLine("\t1 - Pluss");
            Console.WriteLine("\t2 - Minuss");
            Console.WriteLine("\t3 - Multiply");
            Console.WriteLine("\t4 - Divide");
            Console.WriteLine("\t5 - Power");
            Console.WriteLine("Whats your choice?");
            char myopp = char.Parse(Console.ReadLine());
            try
            {
                double result = 0;
                Calculatordemo calc = new Calculatordemo();
                switch (myopp)
                {
                    case '1':
                        result = calc.Addition(firstnum, secondnum);
                        break;
                    case '2':
                        result = calc.Subtraction(firstnum, secondnum);
                        break;
                    case '3':
                        result = calc.Multiplication(firstnum, secondnum);
                        break;
                    case '4':
                        result = calc.Division(firstnum, secondnum);
                        break;
                    case '5':
                        result = calc.Power(firstnum, secondnum);
                        break;
                    default:
                        Console.WriteLine("Invalid operation, please try again.");
                        break;
                }
                Console.WriteLine($"Your result is: {result}");
                Console.WriteLine("Press any key to close the Calculator");
                Console.ReadKey();
            }
            catch (InputCorrectNumbersException e)
            {
                Console.WriteLine($"This input number is not correct, please enter a valid one");
                Console.WriteLine(e.Message);
            }
        }
    }
}
