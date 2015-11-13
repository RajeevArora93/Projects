using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class EmailChecker
    {
        public string GetUserName(string email) 
        {
            if (email.Contains('@'))
            {
                string[] emailSections = email.Split('@');
                return emailSections[0];
            }
            else 
            {
                throw new InvalidEmailException("Invalid Email");
            }
        }
    }
}
