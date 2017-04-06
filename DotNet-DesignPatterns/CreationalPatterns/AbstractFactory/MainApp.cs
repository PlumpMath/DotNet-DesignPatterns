using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MainApp
    {
       public static void Main(string[] args)
        {

            //Execute US Trade
            AssetClassFactory usFactory = new USFactory();

            OrderManager orderManager = new OrderManager(usFactory);
            orderManager.ExecuteTrade();


            AssetClassFactory canadaFactory = new CanadaFactory();

            orderManager = new OrderManager(canadaFactory);
            orderManager.ExecuteTrade();



            // Wait for user input

            Console.ReadKey();
        }        
    }
}
