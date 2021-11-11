using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatordemo
{
    public class calculator
    {
        public static object GetNumbers(int number)
        {

            if (number - 10 == 0)
            {
                return "minuss";
            }
            if (number * 5 == 0) 
            {
                return "multiply";
            }
            if (number % 5 == 0) 
            {
                return "divide";
            }
            return number.ToString();
        }

     
    }
}
