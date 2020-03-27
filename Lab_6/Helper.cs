using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using Lab_5.Exceptions;

namespace Lab_5
{
    public static class Helper
    {
        public static string GetStringValue(TextBox box)
        {
            if (box.Text.Length != 0)
            {
                return box.Text;
            }
            else
                throw new FormValueError($"Empty field in {box.Name}");
        }

        public static int GetIntValue(TextBox box)
        {
            if (box.Text.Length != 0)
            {
                return Convert.ToInt32(box.Text);
            }
            else
                throw new FormValueError($"Empty field in {box.Name}");
        }

        public static bool GetBoolValue(CheckBox box)
        {
            if (box.Checked)
                return true;
            else
                return false;
        }

        public static string GetComboValue(ComboBox box)
        {
            if (box.SelectedIndex > -1)
                return box.SelectedItem.ToString();
            else throw new FormValueError($"item is not set in {box.Name}");
        }
    }
}
