using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = 10;
            Object obj = val; //Boxing
            int i = (int)obj; //Unboxing
            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
