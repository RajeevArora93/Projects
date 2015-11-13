using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class LazyWorker : Worker, Eater
    {
        public void Work()
        {
            Console.WriteLine("I only work when I am being watched");
        }

        public void Eat()
        {
            Console.WriteLine("I eat whenever I feel like it");
        }
    }
}
