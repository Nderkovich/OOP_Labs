using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Lab_5.IT_Lab;

namespace Lab_5
{
    public partial class FormSearch : Form
    {
        BindingList<Computer> items;
        BindingList<Computer> collection;

        public FormSearch(BindingList<Computer> collection)
        {
            InitializeComponent();
            this.collection = collection;
            items = new BindingList<Computer>();
            listSearchResult.DataSource = items;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            items.Clear();
            try
            {
                string value = Helper.GetComboValue(comboSearchOption);
                string searchQuery = Helper.GetStringValue(textSearch);
                Regex r1 = new Regex($"(\\w*){searchQuery}(\\w*)");
                if (value == "MANUFACTURER")
                {
                    foreach (var c in collection)
                    {
                        if (r1.IsMatch(c.Processor.Manufacturer))
                            items.Add(c);
                    }
                }
                else
                {
                    foreach (var c in collection)
                    {
                        if (r1.IsMatch(c.Processor.Model))
                            items.Add(c);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSortFreq_Click(object sender, EventArgs e)
        {
            var s = items.OrderByDescending(p => p.Processor.BaseFrequency).ToList();
            items.Clear();
            foreach (var t in s)
            {
                items.Add(t);
            }
        }

        private void buttonSortRam_Click(object sender, EventArgs e)
        {
            var s = items.OrderByDescending(p => p.RamCapacity).ToList();
            items.Clear();
            foreach (var t in s)
            {
                items.Add(t);
            }
        }

        private void buttonToXml_Click(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(BindingList<Computer>));
            using (FileStream fs = new FileStream("labaratorySearch.xml", FileMode.Create))
            {
                formatter.Serialize(fs, items);
            }
        }
    }
}
