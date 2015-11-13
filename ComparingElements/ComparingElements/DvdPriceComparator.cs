using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingElements
{
    public class DvdPriceComparator : IComparer<Dvd>
    {
        public int Compare(Dvd dvd1, Dvd dvd2)
        {
            if (dvd1.price < dvd2.price)
            {
                return -1;
            }

            if (dvd1.price > dvd2.price)
            {
                return 1;
            }
            return 0;
        }
    }
}
