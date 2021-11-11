using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatordemo
{
    public interface ICalculate
    {
        double Calculate(double a, double b);
    }
    public class Addition : ICalculate
    {

        public double Calculate(double a, double b)
        {
            return a + b;
        }
        
    }
    public class Subtraction : ICalculate
    {
        public double Calculate(double a, double b)
        {
            
            return a - b;
        }
    }
    public class Multiplication : ICalculate
    {
        public double Calculate(double a, double b)
        {
            
            return a * b;
        }
    }
    public class Division : ICalculate
    {
        public double Calculate(double a, double b)
        {
           
            return a / b;
        }
    }
}
