using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Alto_Valyrio.apps.Inventory.Frontend.src.Packing
{
    public class FieldsVisibilityHandler
    {
        public static void Trigger(TextBox txt, int indexException, int index)
        {
            if (indexException != index)
            {
                txt.Enabled = true;
                return;
            }

            txt.Enabled = false;
            txt.Text = String.Empty;
        }
    }
}
