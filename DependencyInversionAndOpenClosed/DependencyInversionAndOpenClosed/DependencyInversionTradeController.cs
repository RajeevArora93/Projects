using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionAndOpenClosed
{
    public class DependencyInversionTradeController
    {
        public void TradeStock(Stock stock) 
        {
            int value = stock.value;
            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}
