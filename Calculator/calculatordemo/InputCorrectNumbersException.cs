using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatordemo
{
    public class InputCorrectNumbersException : Exception
    {
        public InputCorrectNumbersException() 
        {
            
        }

        public InputCorrectNumbersException(string message) : base(message) 
        {
            
        }
        public InputCorrectNumbersException(string message, Exception innerException) : base(message, innerException) 
        {
            
        }




    }
    



}
