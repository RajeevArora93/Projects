using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = "C:/Users/rajeev.arora/Desktop/file.txt";
            //StreamWriter sw = new StreamWriter(path);
            //sw.WriteLine("Hayley smells");
            //sw.Close();

            StreamReader sr = new StreamReader(path);
            StringBuilder sb = new StringBuilder();
            
            while (sr.Peek() != -1) { 
                sb.Append(sr.ReadLine());
            }         
                
            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }
}
