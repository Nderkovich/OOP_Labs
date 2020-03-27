using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab_5.Exceptions;
using Lab_5.IT_Lab;


namespace Lab_5
{
    public partial class FormVideoCard : Form
    {
        public VideoCard videoCard;

        public FormVideoCard()
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
                int frequency = Helper.GetIntValue(textFrequency);
                int memory = Helper.GetIntValue(textMemory);
                bool directX = Helper.GetBoolValue(checkDirectX);
                videoCard = new VideoCard(manufacturer, series, model, frequency, directX, memory);
                this.DialogResult = DialogResult.OK;
                this.Close();
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
    }
}
