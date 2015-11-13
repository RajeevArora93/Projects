using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstution
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlLineWriter flw = new XmlLineWriter();
            flw.Write("Hello World");

            Console.ReadLine();
        }
    }
}
