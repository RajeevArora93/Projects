using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    class Program
    {
        static void Main(string[] args)
        {
            EfficientWorker ew = new EfficientWorker();
            
            ew.Eat();
            ew.Work();

            Console.WriteLine();

            LazyWorker lw = new LazyWorker();

            lw.Eat();
            lw.Work();

            Console.WriteLine();

            RobotWorker rw = new RobotWorker();
           
            rw.Work();

            Console.ReadLine();
        }
    }
}
