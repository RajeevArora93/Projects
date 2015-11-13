using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionAndOpenClosed
{
    public class TraderController
    {
        public void TradeShare(Share share)
        {
            int value = share.value;
            Console.WriteLine(value);
            Console.ReadLine();
        }

        public void TradeBond(Bond bond)
        {
            int value = bond.value;
            Console.WriteLine(value);
            Console.ReadLine();
        }

        public void TradeForeignExchange(ForeignExchange foreignEx)
        {
            int value = foreignEx.value;
            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}
