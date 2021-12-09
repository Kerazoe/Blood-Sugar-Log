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
    public partial class GraphForm : Form
    {
        int numberGood;
        int numberLow;
        int numberHigh;
        public GraphForm(int theNumberGood, int theNumberLow, int theNumberHigh)
        {
            numberGood = theNumberGood;
            numberLow = theNumberLow;
            numberHigh = theNumberHigh;
           
            
            InitializeComponent();
            fillChart();

        }

        private void fillChart()
        {
            chart1.Series[0].Points.AddXY("Number Low", numberLow);
            chart1.Series[0].Points.AddXY("Number Good", numberGood);
            chart1.Series[0].Points.AddXY("Number High", numberHigh);
            chart1.Titles.Add("Blood Sugar Totals Chart");
        }
    }
}
