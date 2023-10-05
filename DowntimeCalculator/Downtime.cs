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
        public float[] numbers = new float[5];
        private float sum;
        private float avg;
        

        public Downtime(float txtDowntime1, float txtDowntime2, float txtDowntime3, float txtDowntime4, float txtDowntime5)
        {
            numbers[0] = txtDowntime1;
            numbers[1] = txtDowntime2;
            numbers[2] = txtDowntime3;
            numbers[3] = txtDowntime4;
            numbers[4] = txtDowntime5;
            Array.Sort(numbers);
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
            set
            {
                sum = value;
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

        public float[] Numbers
        {
            get
            {
                return numbers;
            }
        }

        public float[] SortedArray()
        {
            Array.Sort(numbers);
            return numbers;
        }
    }
}
