using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class Calculator : Form
    {
        int mem;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonClick(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
                try
                {
                    textBox1.Text = PolishNotation.Perform(textBox1.Text).ToString();
                }
                catch (CalculationException ex)
                {
                   MessageBox.Show(ex.Message, "Eror",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                   textBox1.Clear();
                }
        }

        private void buttonErase_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0) 
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void buttonClear_Click(object sender, EventArgs e) => textBox1.Clear();
        
        private void buttonMemPlus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                try
                {
                    mem = PolishNotation.Perform(textBox1.Text);
                }
                catch (CalculationException ex)
                {
                    MessageBox.Show(ex.Message, "Eror",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    textBox1.Clear();
                }
            }
        }

        private void buttonMemMinus_Click(object sender, EventArgs e) => textBox1.Text += mem.ToString();
    }
}
