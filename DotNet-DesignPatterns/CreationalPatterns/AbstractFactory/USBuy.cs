using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class USBuy: Equity
    {
        public override void TradeOrder(FixedIncome fixedIncome)
        {
            Console.WriteLine(this.GetType().Name + " trades " + fixedIncome.GetType().Name);
        }
    }
}
