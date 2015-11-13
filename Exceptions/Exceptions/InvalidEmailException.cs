using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class InvalidEmailException : FormatException
    {
        public InvalidEmailException() : base()
        {

        }

        public InvalidEmailException(string message) : base(message)
        {
        
        }
    }
}
