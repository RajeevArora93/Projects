using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstution
{
    public class XmlLineWriter : FileLineWriter
    {
        public override void Write(string line)
        {
            Console.WriteLine("Writing XML " + line + " to file...");
        }
    }
}
