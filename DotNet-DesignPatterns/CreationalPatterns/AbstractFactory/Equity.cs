using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public abstract class Equity
    {
        public abstract void TradeOrder(FixedIncome fixedIncome);
    }
}
