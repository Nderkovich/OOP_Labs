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
        BindingList<Computer> computers;

        private void InitializeListOfParts()
        {
            // Create the new BindingList of Part type.
            computers = new BindingList<Computer>();

            // Allow new parts to be added, but not removed once committed.        
            computers.AllowNew = true;
            computers.AllowRemove = true;

            // Raise ListChanged events when new parts are added.
            computers.RaiseListChangedEvents = true;

            // Do not allow parts to be edited.
            computers.AllowEdit = true;
        }

        Timer timer;

        public FormLabaratory()
        {
            InitializeComponent();
            InitializeListOfParts();
            timer = new Timer() { Interval = 1000 };
            timer.Tick += timer_Tick;
            timer.Start();
        }

        void FormLabaratory_Load(object sender, EventArgs e)
        {
            InitializeListOfParts();
            listBox1.DataSource = computers;
            computers.AddingNew += new AddingNewEventHandler(UpdateNumberOfElements);
            computers.ListChanged += new ListChangedEventHandler(UpdateNumberOfElements);
        }

        private void lastAction(string act)
        {
            toolStripStatusLabel3.Text = act;
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
            lastAction("Create computer");
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
            computers.Clear();
            foreach (var a in clone)
                computers.Add(a);
            listBox1.DataSource = computers;
            lastAction("Remove computer");
        }

        private void buttonPrice_Click(object sender, EventArgs e)
        {
            int total = 0;
            foreach(var c in listBox1.Items)
            {
                total += ((Computer)c).price;
            }
            MessageBox.Show($"Total price is {total}$");
            lastAction("Get totla price");
        }

        void timer_Tick(object sender, EventArgs e)
        {
            toolDateTime.Text = DateTime.Now.ToString();
        }


        void UpdateNumberOfElements(object sender, EventArgs e)
        {
            toolNumberOfElements.Text = ((BindingList<Computer>)sender).Count.ToString();
        }

        private void buttonToolStrip_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = !toolStrip1.Visible;
        }

        private void toolStripButtonSearch_Click(object sender, EventArgs e)
        {
            var form = new FormSearch(computers);
            form.ShowDialog();
            lastAction("Search");
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("labaratory.xml", FileMode.Create))
            {
                formatter.Serialize(fs, computers);
            }
            lastAction("Save to xml");
        }

        private void toolStripButtonGet_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("labaratory.xml", FileMode.OpenOrCreate))
            {
                computers.Clear();
                foreach (var a in (BindingList<Computer>)formatter.Deserialize(fs))
                    computers.Add(a);
                computers.RaiseListChangedEvents = true;
                listBox1.DataSource = computers;
            }
            lastAction("Get from xml");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            form.ShowDialog();
            lastAction("About");
        }
    }
}