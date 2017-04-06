using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
   /// <summary>
   /// Client Class
   /// </summary>
    public class OrderManager
    {
        private Equity _equity;
        private FixedIncome _fixedIncome;

        public OrderManager(AssetClassFactory factory)
        {
            // TODO: Complete member initialization
            _equity = factory.CreateEquityOrder();
            _fixedIncome = factory.CreateFixedOrder();
        }

        public void ExecuteTrade()
        {
            _equity.TradeOrder(_fixedIncome);
        }
    }
}
