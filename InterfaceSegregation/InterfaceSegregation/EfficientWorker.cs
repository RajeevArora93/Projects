using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class EfficientWorker : Worker, Eater
    {
        public void Work()
        {
            Console.WriteLine("I work as much as I can");
        }

        public void Eat()
        {
            Console.WriteLine("I only eat when I have to");
        }
    }
}
