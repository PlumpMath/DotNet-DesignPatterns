using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// The 'ConcreteFactory' CanadaFactory class
    /// </summary>

    public class CanadaFactory : AssetClassFactory
    {
      
        public override Equity CreateEquityOrder()
        {
            return new CanBuy();
        }

        public override FixedIncome CreateFixedOrder()
        {
            return new CanadaFixedIncome();
        }
    }
}
