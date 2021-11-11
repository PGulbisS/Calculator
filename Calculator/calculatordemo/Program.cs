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

            Calculatordemo User = new Calculatordemo(firstnum, secondnum, myopp);

            Console.WriteLine("-----------------------------------");

            //----------------------------------
            Operator add = Operator.Pluss;
            Operator minus = Operator.Minuss;
            Operator multi = Operator.Multiply;
            Operator divide = Operator.Divide;

            //------------------------------------
            ICalculate adding = new Addition();
            
            double calculatesum = adding.Calculate(firstnum,secondnum);

            ICalculate subtracking = new Subtraction();
            ICalculate multiplier = new Multiplication();
            ICalculate divider = new Division();


            Console.WriteLine(calculatesum);
           










        }
    }
}
