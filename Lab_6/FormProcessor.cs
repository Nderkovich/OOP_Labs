using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab_5.IT_Lab;
using Lab_5.Exceptions;
using System.ComponentModel.DataAnnotations;

namespace Lab_5
{
    public partial class FormProcessor : Form
    {
        public Processor proc;

        public FormProcessor()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string manufacturer = Helper.GetStringValue(textManufacturer);
                string series = Helper.GetStringValue(textSeries);
                string model = Helper.GetStringValue(textModel);
                int numberOfCores = Helper.GetIntValue(textNumberOfCores);
                int baseFrequency = Helper.GetIntValue(textBaseFrequency);
                int maxFrequency = Helper.GetIntValue(textMaxFrequency);
                InstructionSet set = getInstructionSet();
                int cacheSize = Helper.GetIntValue(textCacheSize);
                proc = new Processor(manufacturer, series, model, numberOfCores, baseFrequency, maxFrequency, set, cacheSize);

                var results = new List<ValidationResult>();
                var context = new ValidationContext(proc);
                if (!Validator.TryValidateObject(proc, context, results, true))
                {
                    string result = "";
                    foreach (var error in results)
                    {
                        result += error.ErrorMessage;
                    }
                    MessageBox.Show(result);
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch(FormValueError ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textOnlyInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textIntText_Validation(object sender, CancelEventArgs e)
        {
            TextBox box = (TextBox)sender;
            if (box.Text.Length != 0)
            {
                try
                {
                    Convert.ToInt32(box.Text);
                }
                catch (System.OverflowException ex)
                {
                    MessageBox.Show($"Number too big in {box.Name}");
                }
            }
        }

        private InstructionSet getInstructionSet()
        {
            string comboValue = Helper.GetComboValue(comboUnstructionSet);
            if (comboValue == "32 bit")
                return InstructionSet.BIT32;
            else
                return InstructionSet.BIT64;      
        }
    }
}
