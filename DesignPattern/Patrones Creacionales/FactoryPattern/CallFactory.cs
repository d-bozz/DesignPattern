using DesignPattern.FactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._02_FactoryPattern
{
    public class CallFactory
    {
        static void Main(string[] args)
        {
            SaleFactory storeSaleFactory = new StoreSaleFactory(10);

            ISale venta = storeSaleFactory.GetSale();
            venta.Sell(15);
        }
    }
}
