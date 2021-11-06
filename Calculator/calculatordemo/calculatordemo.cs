using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatordemo
{
    public class calculatordemo
    {
        public double firstNumber;
        public double secondNumber;
        public double result;
        public char operation;

        public calculatordemo(double first, double second, char opp)
        {
            firstNumber = first;
            secondNumber = second;
            operation = opp;
            operations();
        }
        public void operations()
        {
            switch (operation)
            {
                case '1':
                    result = firstNumber + secondNumber;
                    Console.WriteLine("The sum of {0} and {1} is {2}", firstNumber, secondNumber, result);
                    startover();
                    break;
                case '2':
                    result = firstNumber - secondNumber;
                    Console.WriteLine("The differece of {0} and {1} is {2}", firstNumber, secondNumber, result);
                    startover();
                    break;
                case '3':
                    result = firstNumber * secondNumber;
                    Console.WriteLine("The  outcome {0} and {1} is {2}", firstNumber, secondNumber, result);

                    break;
                case '4':
                    result = firstNumber / secondNumber;
                    Console.WriteLine("The division of {0} and {1} is {2}", firstNumber, secondNumber, result);
                    startover();
                    break;

                default:
                    Console.WriteLine("Invalid operation, please enter valid operation");
                    End();
                    break;

            }

        }
        public void startover()
        {
            Console.WriteLine("Do you want to continue?\nIf \'Yes\' then press and enter (Y)" + "If you want to exit press any other key");
            string YesorNo = Console.ReadLine();
            bool mybool = (YesorNo == "y" || YesorNo == "Y");
            if (mybool == true)
            {
                repeat();
            }
            else
            {

            }

        }
        public void repeat()
        {
            firstNumber = result;
            Console.WriteLine("Type here the next number");

            secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Choose an option");
            Console.WriteLine("\t1 - Pluss");
            Console.WriteLine("\t2 - Minuss");
            Console.WriteLine("\t3 - Multiply");
            Console.WriteLine("\t4 - Divide");
            Console.WriteLine("Whats your choice?");
            operation = char.Parse(Console.ReadLine());
            operations();

        }
        public void End()
        {
            Console.WriteLine("Final Result is {0}", result);
            Console.WriteLine("Press any key to Exit the application");
            Console.ReadKey();
        }
    }
}
