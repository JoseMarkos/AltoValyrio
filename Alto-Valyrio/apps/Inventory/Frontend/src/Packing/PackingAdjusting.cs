using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Alto_Valyrio.apps.Inventory.Frontend.src.Packing
{
    public class PackingAdjusting
    {
        public PackingAdjusting(int units, int pricePerUnits)
        {
            Units = units;
            PricePerUnits = pricePerUnits;
        }

        public int Units { get; set; }
        public int PricePerUnits { get; set; }

        public decimal PackingPrice()
        {
            return Units * PricePerUnits;
        }

        public override string ToString()
        {
            return PackingPrice().ToString();
        }
    }
}
