using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Alto_Valyrio.src.Shared.apps.Frontend.Templates
{
    public class Utils
    {
        public static void CleanTextBoxInputs(Panel panel)
        {
            foreach (var item in panel.Controls)
            {
                bool isTextBox = item.GetType().ToString() == "System.Windows.Forms.TextBox";

                if (isTextBox)
                {
                    var txt = (TextBox)item;

                    txt.Text = String.Empty;
                }
            }
        }

        public static void CleanComboBoxInputs(Panel panel)
        {
            foreach (var item in panel.Controls)
            {
                bool isComboBox = item.GetType().ToString() == "System.Windows.Forms.ComboBox";

                if (isComboBox)
                {
                    var combo = (ComboBox)item;

                    combo.SelectedIndex = -1;
                }
            }
        }

        public static void CleanNotificationLabel(Label label)
        {
            label.Text = String.Empty;
        }
    }
}
