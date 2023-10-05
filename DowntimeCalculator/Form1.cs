using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DowntimeCalculator //The entire app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createDowntimeArray_Click(object sender, EventArgs e)
        {          
            //If one or all of the text boxes aren't inputted the following warnings appear.
            if (string.IsNullOrEmpty(txtDowntime1.Text))
            {
                MessageBox.Show("Please type in a valid number in Downtime 1.");
            }     
            if (string.IsNullOrEmpty(txtDowntime2.Text))
            {
                MessageBox.Show("Please type in a valid number in Downtime 2.");
            }            
            if (string.IsNullOrEmpty(txtDowntime3.Text))
            {
                MessageBox.Show("Please type in a valid number in Downtime 3.");
            }            
            if (string.IsNullOrEmpty(txtDowntime4.Text))
            {
                MessageBox.Show("Please type in a valid number in Downtime 4.");
            }            
            if (string.IsNullOrEmpty(txtDowntime5.Text))
            {
                MessageBox.Show("Please type in a valid number in Downtime 5.");
            }
            else
            {
                Downtime calculate = new Downtime(float.Parse(txtDowntime1.Text), float.Parse(txtDowntime2.Text), float.Parse(txtDowntime3.Text),
                    float.Parse(txtDowntime4.Text), float.Parse(txtDowntime5.Text));
                calculate.SumArray();
                MessageBox.Show("Total: " + calculate.Sum.ToString());
            }
        }

        private void btnAvgDowntime_Click(object sender, EventArgs e)
        {
            Downtime calculate = new Downtime(float.Parse(txtDowntime1.Text), float.Parse(txtDowntime2.Text), float.Parse(txtDowntime3.Text),
                float.Parse(txtDowntime4.Text), float.Parse(txtDowntime5.Text));
            calculate.SumArray();
            calculate.AvgArray();
            
            outputAvgDowntime.Text = "Average downtime: " + calculate.Avg.ToString() + "\r\n" + 
                "Sorted downtime values are: " + "\r\n";
        }
    }
}
