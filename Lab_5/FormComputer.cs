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

namespace Lab_5
{
    public partial class FormComputer : Form
    {
        Processor procesor;
        VideoCard video;
        public Computer comp;

        Timer timer;

        public FormComputer()
        {
            InitializeComponent();
            timer = new Timer() { Interval = 1000 };
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (procesor == null || video == null)
            {
                MessageBox.Show("You need to set processor and videocard first");
            }
            else
            {
                try
                {
                    int memory = Helper.GetIntValue(textMemorySize);
                    int driveSize = Helper.GetIntValue(textDriveSize);
                    DateTime datePurchse = datePurchaseDate.Value;
                    ComputerType compType = GetComputerType();
                    RAMType ramType = GetRAMType();
                    DriveType driveType = GetDriveType();
                    comp = new Computer(compType, procesor, video, ramType, driveSize, driveType, datePurchse, memory);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch(FormValueError ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonProcessor_Click(object sender, EventArgs e)
        {
            using (var form = new FormProcessor())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Processor val = form.proc;
                    this.procesor = val;
                }
            }
        }

        private void buttonVideoCard_Click(object sender, EventArgs e)
        {
            using (var form = new FormVideoCard())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    VideoCard val = form.videoCard;
                    this.video = val;
                }
            }
        }

        private ComputerType GetComputerType()
        {
            string comboValue = Helper.GetComboValue(comboCompType);
            if (comboValue == "Server")
                return ComputerType.SERVER;
            else if (comboValue == "Work station")
                return ComputerType.WORKSTATION;
            else
                return ComputerType.NOTEBOOK;
        }

        private RAMType GetRAMType()
        {
            string comboValue = Helper.GetComboValue(comboRAMType);
            if (comboValue == "DDR2")
                return RAMType.DDR2;
            else if (comboValue == "DDR3")
                return RAMType.DDR3;
            else
                return RAMType.DDR4;
        }

        private DriveType GetDriveType()
        {
            string comboValue = Helper.GetComboValue(comboDriveType);
            if (comboValue == "SSD")
                return DriveType.SSD;
            else
                return DriveType.HDD;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            toolDateTime.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongDateString();
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
