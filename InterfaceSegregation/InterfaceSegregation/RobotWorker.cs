using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class RobotWorker : Worker
    {

        public void Work()
        {
            Console.WriteLine("I work 24 hours a day");
        }

        //This method will never be called - Interface polution
        //Split the interface up into two different interfaces
        //Worker implements work 
        //Eater implements eat
       
        /*
        public void Eat()
        { 
         * 
        }
        */
    }
}
