using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capstone
{
    public partial class BsForm : Form
    {
        public void CreateMyTimePicker()
        {
            timePicker.CustomFormat = "hh:mm tt";
        }
        public String theBloodSugar()
        {
            return textBox1.Text;
        }
        public DateTime theDate()
        {
            return datePicker.Value;
        }
        public DateTime theTime()
        {
            return timePicker.Value;
        }
        public BsForm(int bs, DateTime dt)
        {
            InitializeComponent();
            CreateMyTimePicker();
            datePicker.Value = dt.Date;
            timePicker.Value = dt;
            textBox1.Text = bs.ToString();
        }
        public BsForm()
        {
            InitializeComponent();
            CreateMyTimePicker();
            datePicker.Value = DateTime.Today;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
