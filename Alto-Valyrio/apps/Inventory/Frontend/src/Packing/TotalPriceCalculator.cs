using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.apps.Inventory.Frontend.src.Packing
{
    public class TotalPriceCalculator
    {
        public static decimal Calculate(int units, decimal price)
        {
            return units * price;
        }
    }
}
