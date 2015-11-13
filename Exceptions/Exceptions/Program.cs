using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //console.writeline(divide(2, 0));
            //console.writeline(defensivedivide(2, 0));

            string email = "LukeSkywalkerforce.com";
            EmailChecker ec = new EmailChecker();

            string username = string.Empty;

            try
            {
                username = ec.GetUserName(email);
            }
            catch (InvalidEmailException e)
            {

                Console.WriteLine(e.Message);
            }
            finally 
            {
                Console.WriteLine("I will always run, no matter what! bitch! ");
            }
            

            Console.WriteLine(username);

            Console.ReadLine();   
        }

        public static int Divide(int num1, int num2)
        {
            int result = 0;

            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }

        public static int DefensiveDivide(int num1, int num2)
        {
            int result = 0;

            if (num2 != 0)
            {
                result = num1 / num2;
            }
            else 
            { 
               Console.WriteLine("You cannot divide by zero!");              
            }      

            return result;
        } 
    }
}
