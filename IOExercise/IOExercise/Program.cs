using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/rajeev.arora/Desktop/file.txt";

            Console.WriteLine(charCounter(path, 'A'));
            Console.ReadLine();

            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your address");
            string address = Console.ReadLine();

            Console.WriteLine("Please enter your email address");
            string email = Console.ReadLine();

            Console.WriteLine("Please enter your mobile number");
            string mobile = Console.ReadLine();

            UserRegister useReg = new UserRegister();
            useReg.InputInfo(path, name, address, email, mobile);

            Console.WriteLine("Press the enter key to quit");

           // useReg.CreateUsers(path);
            Console.ReadLine();
         }

        public static int charCounter(string path, char charToCheck)
        {
            int count = 0;
            StreamReader reader = new StreamReader(path);
            StringBuilder builder = new StringBuilder();

            while (reader.Peek() != -1)
            {
                builder.Append(reader.ReadLine());
            }

            foreach (char c in builder.ToString())
            {

                if (c.ToString() == charToCheck.ToString().ToLower())
                {
                    count++;
                }
            }

            return count;
        }
    }
}
