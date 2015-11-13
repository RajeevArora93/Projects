using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionAndOpenClosed
{
    class Program
    {
        static void Main(string[] args)
        {
            DependencyInversionTradeController ditc = new DependencyInversionTradeController();
            Gilt gilt = new Gilt() { value = 10 };
            Bond bond = new Bond() { value = 100 };
            ditc.TradeStock(gilt);
            ditc.TradeStock(bond);
        }
    }
}
