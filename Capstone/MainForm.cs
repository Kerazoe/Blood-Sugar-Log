using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Web;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace Capstone
{

    public partial class MainForm : Form
    {
        List<BsEntry> list = new List<BsEntry>();
        public int highBloodSugar = 200;
        public int lowBloodSugar = 70;
        public MainForm()
        {
            InitializeComponent();
            initializeTable();
        }
        public void initializeTable()
        {
            table1.Columns.Add("bloodSugar", "Blood Sugar");
            table1.Columns.Add("dateTime", "Date and Time");
            table1.Columns[1].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm tt";
            
        }
        public void generateBs()
        {

            int bloodSugar;
            DateTime date;
            DateTime time;
            DateTime dateAndTime;
            Random r = new Random();
            DateTime start = new DateTime(2021, 9, 8);
            int range = (DateTime.Today - start).Days;

            DateTime startTime = DateTime.Today.AddHours(7);
       
            for (int i = 0; i < 720; i++)
            {
                time = startTime.AddMinutes(r.Next(960));
                date = start.AddDays(r.Next(range));
                dateAndTime = date.Date + time.TimeOfDay;
                bloodSugar = r.Next(50, 320);
                table1.Rows.Add(bloodSugar, dateAndTime);
            }
        }
        public void updateHighLowCount()
        {
            int lowCount = 0;
            int highCount = 0;
            int goodCount = 0;
            list.Clear();
            foreach (DataGridViewRow row in table1.Rows)
            {
                list.Add(new BsEntry(Convert.ToInt32(row.Cells[0].Value), Convert.ToDateTime(row.Cells[1].Value)));
            }
            foreach (var bsEntry in list)
            {
                if (bsEntry.getBloodSugar() >= highBloodSugar)
                {
                    highCount++;
                }
                if (bsEntry.getBloodSugar() <= lowBloodSugar)
                {
                    lowCount++;
                }
                if(bsEntry.getBloodSugar() < highBloodSugar && bsEntry.getBloodSugar() > lowBloodSugar)
                {
                    goodCount++;
                }
            }

            numberLow.Text = lowCount.ToString();
            numberHigh.Text = highCount.ToString();
            numberGood.Text = goodCount.ToString();
        }
       
        public void updateAverage30day()
        {
            int sum = 0;
            int count = 0;
            double avg;
            list.Clear();
            foreach (DataGridViewRow row in table1.Rows)
            {
                list.Add(new BsEntry(Convert.ToInt32(row.Cells[0].Value), Convert.ToDateTime(row.Cells[1].Value)));
            }
            foreach (var bsEntry in list)
            {
                
                if ((DateTime.Now - bsEntry.getDateTime()).TotalDays <= 30)
                {
                    
                    sum += bsEntry.getBloodSugar();
                    count++;
                }
            }

            if (count > 0)
            {
                avg = (double)sum / (double)count;
                average30day.Text = Math.Round(avg, 1).ToString();
                average30dayCount.Text = "(" + count + " blood sugars)";
            }
            else
            {
                average30day.Text = "";
                average30dayCount.Text = "";
            }
        }
        public void updateAverage60day()
        {
            int sum = 0;
            int count = 0;
            double avg;
            list.Clear();
            foreach (DataGridViewRow row in table1.Rows)
            {
                list.Add(new BsEntry(Convert.ToInt32(row.Cells[0].Value), Convert.ToDateTime(row.Cells[1].Value)));
            }
            foreach (var bsEntry in list)
            {
                
                if ((DateTime.Now - bsEntry.getDateTime()).TotalDays <= 60)
                {

                    sum += bsEntry.getBloodSugar();
                    count++;
                }
            }

            if (count > 0)
            {
                avg = (double)sum / (double)count;
                average60day.Text = Math.Round(avg, 1).ToString();
                average60dayCount.Text = "(" + count + " blood sugars)";
            }
            else
            {
                average60day.Text = "";
                average60dayCount.Text = "";
            }
        }
        public void updateAverage90day()
        {
            int sum = 0;
            int count = 0;
            double avg;
            list.Clear();
            foreach (DataGridViewRow row in table1.Rows)
            {
                list.Add(new BsEntry(Convert.ToInt32(row.Cells[0].Value), Convert.ToDateTime(row.Cells[1].Value)));
            }
            foreach (var bsEntry in list)
            {
                
                if ((DateTime.Now - bsEntry.getDateTime()).TotalDays <= 90)
                {

                    sum += bsEntry.getBloodSugar();
                    count++;
                }
            }

            if (count > 0)
            {
                avg = (double)sum / (double)count;
                average90day.Text = Math.Round(avg, 1).ToString();
                average90dayCount.Text = "(" + count + " blood sugars)";
            }
            else
            {
                average90day.Text = "";
                average90dayCount.Text = "";
            }
        }
        public void updateAverageAllTime()
        {
            int sum = 0;
            int count = 0;
            double avg;
            list.Clear();
            foreach (DataGridViewRow row in table1.Rows)
            {
                list.Add(new BsEntry(Convert.ToInt32(row.Cells[0].Value), Convert.ToDateTime(row.Cells[1].Value)));
            }
            foreach (var bsEntry in list)
            {       
                sum += bsEntry.getBloodSugar();
                count++;
            }

            if (count > 0)
            {
                avg = (double)sum / (double)count;
                averageAllTime.Text = Math.Round(avg, 1).ToString();
                averageAllTimeCount.Text = "(" + count + " blood sugars)";
            }
            else
            {
                averageAllTime.Text = "";
                averageAllTimeCount.Text = "";
            }
        }

        public void updateLabels()
        {
            bsCountLabel.Text = table1.RowCount.ToString();
            updateAverage30day();
            updateAverage60day();
            updateAverage90day();
            updateAverageAllTime();
            updateHighLowCount();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using(BsForm bsForm = new BsForm())
            {
                String bloodSugarString;
                DateTime theDate;
                DateTime theTime;
                DateTime dateAndTime;
                if(bsForm.ShowDialog() == DialogResult.OK)
                {
                    bloodSugarString = bsForm.theBloodSugar();
                    theDate = bsForm.theDate();
                    theTime = bsForm.theTime();
                    dateAndTime = theDate.Date + theTime.TimeOfDay;
                    try
                    {
                        int bloodSugar = Int32.Parse(bloodSugarString);
                        if(bloodSugar <1 || bloodSugar> 1000)
                        {
                            MessageBox.Show("Invalid blood sugar valid range 1-1000", "Invalid Blood Sugar");
                            return;
                        }
                        table1.Rows.Add(bloodSugar, dateAndTime);
                        updateLabels();
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Invalid blood sugar number, please try again", "Invalid Blood Sugar");
                        Console.WriteLine($"Unable to parse '{bloodSugarString}'");
                    }
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = table1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                for (int i = 0; i < selectedRowCount; i++)
                {
                    table1.Rows.RemoveAt(table1.SelectedRows[0].Index);
                 
                }
            }
            updateLabels();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Json Files (*.json)|*.json";
            saveFileDialog1.DefaultExt = "json";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        
                        list.Clear();
                        foreach (DataGridViewRow row in table1.Rows)
                        {
                            list.Add(new BsEntry(Convert.ToInt32(row.Cells[0].Value), Convert.ToDateTime(row.Cells[1].Value)));
                        }

                        string jsonString = JsonConvert.SerializeObject(list, Formatting.Indented);
                        
                        File.WriteAllText(saveFileDialog1.FileName, jsonString);
                        break;
                }
            }
        }

        private void loadMenuItem_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Json Files (*.json)|*.json";
            openFileDialog.DefaultExt = "json";
            openFileDialog.AddExtension = true;
            //openFileDialog.ShowDialog();

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    filePath = openFileDialog.FileName;
                    

                    list = JsonConvert.DeserializeObject<List<BsEntry>>(File.ReadAllText(filePath));
                    table1.Rows.Clear();
                    foreach (BsEntry entry in list)
                    {
                        
                        table1.Rows.Add(entry.getBloodSugar(), entry.getDateTime());
                    }
                    updateLabels();
                    table1.Sort(table1.Columns[1], ListSortDirection.Descending);

                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }

        private void setHighLowButton_Click(object sender, EventArgs e)
        {
            using (HighLowForm highLowForm = new HighLowForm(lowBloodSugar, highBloodSugar))
            {
                String highBloodSugarString;
                String lowBloodSugarString;
                if (highLowForm.ShowDialog() == DialogResult.OK)
                {
                    highBloodSugarString = highLowForm.theHighBloodSugar();
                    lowBloodSugarString = highLowForm.theLowBloodSugar();

                    try
                    {
                        highBloodSugar = Int32.Parse(highBloodSugarString);
                        if (highBloodSugar < 1 || highBloodSugar > 1000)
                        {
                            MessageBox.Show("Invalid blood sugar valid range 1-1000", "Invalid Blood Sugar");
                            return;
                        }
                        lowBloodSugar = Int32.Parse(lowBloodSugarString);
                        if (lowBloodSugar < 1 || lowBloodSugar > 1000)
                        {
                            MessageBox.Show("Invalid blood sugar valid range 1-1000", "Invalid Blood Sugar");
                            return;
                        }
                        updateLabels();
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Invalid blood sugar number, please try again", "Invalid Blood Sugar");
                    }
                }
            }
        }

        private void graphButton_Click(object sender, EventArgs e)
        {
            int theNumberGood = 0;
            int theNumberLow = 0;
            int theNumberHigh = 0;
            try
            {
                theNumberGood = Int32.Parse(numberGood.Text);
                theNumberLow = Int32.Parse(numberLow.Text);
                theNumberHigh = Int32.Parse(numberHigh.Text);
                if(theNumberGood == 0 && theNumberLow ==0 && theNumberHigh == 0)
                {
                    MessageBox.Show("No blood sugars to graph");
                }
                else
                {
                    GraphForm graphForm = new GraphForm(theNumberGood, theNumberLow, theNumberHigh);
                    graphForm.Show();
                }
            }
            catch
            {
                MessageBox.Show("Invalid numbers for blood sugar totals");
            }
        }

        private void newMenuItem_Click(object sender, EventArgs e)
        {
            table1.Rows.Clear();
            updateLabels();

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
                table1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                using (BsForm bsForm = new BsForm((int)table1.SelectedRows[0].Cells[0].Value,
                    (DateTime)table1.SelectedRows[0].Cells[1].Value))
                {
                    bsForm.Text = "Edit Blood Sugar";
                    String bloodSugarString;

                    DateTime theDate;
                    DateTime theTime;
                    DateTime dateAndTime;
                    if (bsForm.ShowDialog() == DialogResult.OK)
                    {

                        bloodSugarString = bsForm.theBloodSugar();

                        theDate = bsForm.theDate();

                        theTime = bsForm.theTime();

                        dateAndTime = theDate.Date + theTime.TimeOfDay;

                        try
                        {
                            int bloodSugar = Int32.Parse(bloodSugarString);
                            if (bloodSugar < 1 || bloodSugar > 1000)
                            {
                                MessageBox.Show("Invalid blood sugar valid range 1-1000", "Invalid Blood Sugar");
                                return;
                            }
                            
                            table1.SelectedRows[0].Cells[0].Value = bloodSugar;
                            table1.SelectedRows[0].Cells[1].Value = dateAndTime;
                            updateLabels();
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Invalid blood sugar number, please try again", "Invalid Blood Sugar");
                            Console.WriteLine($"Unable to parse '{bloodSugarString}'");
                        }

                    }
                }
            }
            else if (selectedRowCount == 0)
            {
                MessageBox.Show("Nothing is selected, select 1 blood sugar to edit");
            }
            else
            {
                MessageBox.Show("More than one row is selected, select 1 blood sugar to edit");
            }
        }
    }
}
