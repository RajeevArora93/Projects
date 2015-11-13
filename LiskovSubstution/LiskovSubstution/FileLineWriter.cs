using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstution
{
    public class FileLineWriter
    {
        public virtual void Write(string line) 
        {
            Console.WriteLine("Writing " + line + " to file...");
        }
    }
}
