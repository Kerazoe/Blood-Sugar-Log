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
    public partial class HighLowForm : Form
    {
        public HighLowForm(int lowBloodSugar, int highBloodSugar)
        {
            InitializeComponent();
            currentLowLabel.Text = "(Current is: " + lowBloodSugar + ")";
            currentHighLabel.Text = "(Current is: " + highBloodSugar + ")";
        }
        public String theLowBloodSugar()
        {
            return lowBloodSugarBox.Text;
        }
        public String theHighBloodSugar()
        {
            return highBloodSugarBox.Text;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HighLowForm_Load(object sender, EventArgs e)
        {

        }
    }
}
