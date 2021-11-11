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
            Console.WriteLine("Whats your choice?");
            char myopp = char.Parse(Console.ReadLine());

            double result = 0;
            Calculatordemo calc = new Calculatordemo();
            if (myopp == '1')
            {
                result = calc.Addition(firstnum, secondnum);
            }
            else if (myopp == '2')
            {
                result = calc.Subtraction(firstnum, secondnum);
            }
            else if (myopp == '3')
            {
                result = calc.Multiplication(firstnum, secondnum);
            }
            else if (myopp == '4') 
            {
                
                try
                {
                    result = calc.Division(firstnum, secondnum);
                }
                catch(InputCorrectNumbersException e)
                {

                    Console.WriteLine($"This input number is not correct, please enter a valid one");
                    Console.WriteLine(e.Message);
                    return;
                }
            }
            
            Console.WriteLine($"Your result is: {result}");



        }
    }
}
