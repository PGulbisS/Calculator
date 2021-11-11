using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatordemo
{
    public interface ICalculatedemo
    {
       double Addition(double a, double b);
       double Subtraction(double a, double b);
       double Multiplication(double a, double b);
       double Division(double a, double b);

       double Power(int a, int b);

       // double Sqrt(int a);

        int Factorial(int a);

       // int LN(int a);

        //int sin(int a);
    }


    public class Calculatordemo : ICalculatedemo
    {
        public double firstNumber;
        public double secondNumber;

        public double Addition(double a, double b)
        {
            return a + b;
        }
 
        public double Subtraction(double a, double b)
        {
            return a-b;
        }

        public double Multiplication(double a, double b)
        {
            return a * b;
        }
        public double Division(double a, double b) 
        {
            return a / b;
        }
        public double Power(int a, int b) 
        { 
            int result = 1;
            for (int i = 1; i <= a; i++) 
            {
                result = MathPow(i);
            }
           
            return result;

        }
        public int Factorial(int a)
        {
            int result = 1;
            for (int i = 1; i <= a; i++)
            {
                result = result * i;
            }
            return result;
        }






        

        


    }
}
