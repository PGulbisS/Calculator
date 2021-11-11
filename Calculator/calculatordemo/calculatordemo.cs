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
        double Power(double a, double b);
        double Sqrt(int a);
        int Factorial(int a);
        double Log(int a);
        double Sin(int a);
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
            return a - b;
        }
        public double Multiplication(double a, double b)
        {
            return a * b;
        }
        public double Division(double a, double b)
        {
            if (b == 0)
            {
                throw new InputCorrectNumbersException("You cannot divide by zero");
            }
            return a / b;
        }
        public double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }
        public double Sqrt(int a)
        {
            return Math.Sqrt(a);
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
        public double Log(int a)
        {
            return Math.Log(a);
        }
        public double Sin(int a)
        {
            return Math.Sin(a);
        }

    }
}
