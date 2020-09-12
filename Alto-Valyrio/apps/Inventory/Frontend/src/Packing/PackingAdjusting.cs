using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace Alto_Valyrio.apps.Inventory.Frontend.src.Packing
{
    public class PackingAdjusting
    {
        public static int GetPakingUnits(TextBox txt)
        {
            if (txt.Enabled)
            {
                return int.Parse(txt.Text);
            }

            return 0;
        }
    }
}
