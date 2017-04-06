using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
   /// <summary>
  /// The 'AbstractFactory' abstract class
  /// </summary>
   public abstract class AssetClassFactory
    {
        public abstract Equity CreateEquityOrder();
        public abstract FixedIncome CreateFixedOrder();
    }
}
