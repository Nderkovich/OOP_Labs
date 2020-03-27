using Lab_5.IT_Lab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Lab_5
{
    public partial class FormLabaratory : Form
    {
        XmlSerializer formatter = new XmlSerializer(typeof(BindingList<Computer>));
        BindingList<Computer> computers = new BindingList<Computer>();
        public FormLabaratory()
        {
            InitializeComponent();
            listBox1.DataSource = computers;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var form = new FormComputer())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ListView v = new ListView();
                    computers.Add(form.comp);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BindingList<Computer> clone = new BindingList<Computer>(computers.ToList());
            if (listBox1.SelectedIndex > -1)
            {
                foreach (var c in listBox1.SelectedItems)
                {
                    clone.Remove((Computer)c);
                }
            }
            computers = clone;
            listBox1.DataSource = computers;
        }

        private void buttonPrice_Click(object sender, EventArgs e)
        {
            int total = 0;
            foreach(var c in listBox1.Items)
            {
                total += ((Computer)c).price;
            }
            MessageBox.Show($"Total price is {total}$");
        }

        private void buttonToXml_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("labaratory.xml", FileMode.Create))
            {
                formatter.Serialize(fs, computers);
            }
        }

        private void buttonFromXml_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("labaratory.xml", FileMode.OpenOrCreate))
            {
                 computers = (BindingList<Computer>)formatter.Deserialize(fs);
                 listBox1.DataSource = computers;
            }
        }
    }
}