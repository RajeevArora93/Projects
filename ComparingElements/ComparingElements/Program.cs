using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingElements
{
    class Program
    {
        static void Main(string[] args)
        {


            //Overriding equals method
            //Dvd dvd1 = new Dvd() { id = 1, title = "Peter Pan" };
            //Dvd dvd2 = new Dvd() { id = 1, title = "Peter Pan" };

            //bool areEqual = dvd1.Equals(dvd2);

            //Console.WriteLine(areEqual);

            //Using IComparable and IComparer
            Dvd dvd1 = new Dvd() { id = 2, title = "Lord of the Rings"};
            Dvd dvd2 = new Dvd() { id = 4, title = "Star Wars" };
            Dvd dvd3 = new Dvd() { id = 1, title = "Harry Potter" };
            Dvd dvd4 = new Dvd() { id = 3, title = "Back to the Future" };

            List<Dvd> listOfDvd = new List<Dvd>() 
            {
                dvd1, dvd2, dvd3, dvd4 
            };

            listOfDvd.Sort(new DvdIdComparator());

            foreach (Dvd d in listOfDvd)
            {
                Console.WriteLine(d.id);
            }

            Console.ReadLine();
        }
    }
}
