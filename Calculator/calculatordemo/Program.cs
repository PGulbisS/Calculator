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

            calculatordemo User = new calculatordemo(firstnum, secondnum, myopp);
        }
    }
}
