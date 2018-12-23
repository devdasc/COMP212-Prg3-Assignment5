using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devdas_Chatterjee_Lab05_EX01
{
    public partial class Form1 : Form
    {
        private static readonly int intArrayLength = 10;
        private static readonly int doubleArrayLength = 10;
        private int[] intData = new int[intArrayLength];
        private double[] doubleData = new double[doubleArrayLength];
        Random random = new Random();
       
        public Form1()
        {
            InitializeComponent();
            // load integer data
            textBox_int_value.AppendText(textBox_int_value.Text + "   SL" + "                         " + "Value");
            textBox_int_value.AppendText(Environment.NewLine);

            for (int i = 0; i < intArrayLength; i++)
            {
                intData[i] = random.Next(1, 100);
                textBox_int_value.Text = textBox_int_value.Text + "    " + i.ToString() + "                         " + intData[i].ToString();
                textBox_int_value.AppendText(Environment.NewLine);
            }
            // load double data
            textBox_double_value.AppendText(textBox_double_value.Text + "   SL" + "                         " + "Value");
            textBox_double_value.AppendText(Environment.NewLine);

            for (int i = 0; i < doubleArrayLength; i++)
            {
                doubleData[i] = Math.Round(random.NextDouble(0.5, 100.5), 2, MidpointRounding.AwayFromZero);
                textBox_double_value.Text = textBox_double_value.Text + "    " + i.ToString() + "                         " + doubleData[i].ToString();
                textBox_double_value.AppendText(Environment.NewLine);
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }
        // Generic search method
        private static int SearchData<T>(T[]ArryData, T searchNumber) where T : IComparable<T>
        {
            var location = -1;
            var searchData = searchNumber;
            for(int counter = 0; counter < ArryData.Length; counter++)
            {
                if (ArryData[counter].CompareTo(searchData) == 0)
                {
                    location = counter;
                }
            }
            return location;
        }
        
        // method for int search
        private void button_int_search_Click(object sender, EventArgs e)
        {
            try
            {
                var result = SearchData(intData, Convert.ToInt32(textBox_int_search.Text));
                if (result == -1)
                {
                    textBox_int_search_result.Text = "Number was not found. Return value is: "+result;
                }
                else
                {
                    textBox_int_search_result.Text = "Number was found in " + result+" array position";
                }
            }
            catch(FormatException ee)
            {
                //MessageBox.Show("You have entered an invalid type" + " -error- " + ee);
                textBox_int_search_result.Text = "You entered an invalid type";
            }
        }
        // method for double search
        private void button_double_search_Click(object sender, EventArgs e)
        {
            try
            {
                var result = SearchData(doubleData, Convert.ToDouble(textBox_double_search.Text));
                if (result == -1)
                {
                    textBox_double_search_result.Text = "Number was not found. Return value is: " + result;
                }
                else
                {
                    textBox_double_search_result.Text = "Number was found in " + result + " array position";
                }
            }
            catch (FormatException ee)
            {
                //MessageBox.Show("You have entered an invalid type" + " -error- " + ee);
                textBox_double_search_result.Text = "You have entered invalid type";
            }
        }

        private void textBox_int_value_TextChanged(object sender, EventArgs e)
        {

        }
    }
    // random generator class
    public static class RandomGenerator
    {
        public static double NextDouble(this Random random,double minValue,double maxValue)
        {
            return random.NextDouble() * (maxValue - minValue) + minValue;
        }
    }
}
