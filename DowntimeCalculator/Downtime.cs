using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DowntimeCalculator
{
    internal class Downtime
    {
        float[] numbers = new float[5];
        private float sum;
        private float avg;
        

        public Downtime(float txtDowntime1, float txtDowntime2, float txtDowntime3, float txtDowntime4, float txtDowntime5)
        {
            numbers[0] = txtDowntime1;
            numbers[1] = txtDowntime2;
            numbers[2] = txtDowntime3;
            numbers[3] = txtDowntime4;
            numbers[4] = txtDowntime5;
        }

        public Downtime()
        {
        }

        public float Sum
        {
            get
            {
                return sum;
            }
        }

        public float SumArray()
        {
            foreach (float value in numbers)
            {
                sum += value;
            }
            return sum;
        }

        public float Avg
        {
            get 
            { 
                return avg; 
            }
        }

        public float AvgArray() 
        {
            foreach (float value in numbers)
            {
                avg = numbers.Average();
            }
            return avg;
        }

        public string SortedArray()
        {
            Array.Sort(numbers);
            foreach (float value in numbers)
            {
                MessageBox.Show(numbers);
            }
        }
    }
}
