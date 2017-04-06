using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// The 'ConcreteFactory' USFactory class
    /// </summary>

    public class USFactory : AssetClassFactory
    {
       
        public override Equity CreateEquityOrder()
        {
            return new USBuy();
        }

        public override FixedIncome CreateFixedOrder()
        {
            return new USFixedIncome();
        }
    }
}
