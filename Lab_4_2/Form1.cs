using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4_2
{
    public partial class Form1 : Form
    {
        private CandyBoxCollection collection = new CandyBoxCollection();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                collection = new CandyBoxCollection(Convert.ToInt32(textBox1.Text));
                PrintColletion(textBox2, collection);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintColletion(TextBox textbox, IEnumerable<CandyBox> col)
        {
            textbox.Clear();
            foreach(var box in col)
            {
                textbox.Text += box.ToString() + "\r\n";
            }
        }

        private void buttonSortAsc_Click(object sender, EventArgs e)
        {
            PrintColletion(textBox3, collection.SorterList(0));
        }

        private void buttonSortDesc_Click(object sender, EventArgs e)
        {
            PrintColletion(textBox3, collection.SorterList(1));
        }

        private void buttonQuery1_Click(object sender, EventArgs e)
        {
            PrintColletion(textBox3, collection.LimeAndPeach());
        }

        private void buttonQuery2_Click(object sender, EventArgs e)
        {
            PrintColletion(textBox3, collection.ChocalteMoreThanTen());
        }

        private void buttonQuery3_Click(object sender, EventArgs e)
        {
            PrintColletion(textBox3, collection.ALotOfCandies());
        }
    }
}
