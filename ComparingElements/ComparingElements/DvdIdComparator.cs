using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingElements
{
    public class DvdIdComparator : IComparer<Dvd>
    {
        public int Compare(Dvd dvd1, Dvd dvd2)
        {
            if (dvd1.id < dvd2.id)
            {
                return -1;
            }

            if (dvd1.id > dvd2.id)
            {
                return 1;
            }
            return 0;
        }
    }
}
