using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] a = { "Celsius","Fahrenheit"};
            string[] b = { "Fahrenheit","Celsius"};
            comboBox1.DataSource = a;
            comboBox2.DataSource = b;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            double startingTemp, resultTemp;
            startingTemp = double.Parse(textBox1.Text);
            if (comboBox1.Text == "Celsius" && comboBox2.Text == "Fahrenheit")
            {
                resultTemp = (startingTemp * (1.8) + 32);
                label3.Text = resultTemp.ToString() + " Degrees Fahrenheit";
            }
            if (comboBox1.Text == "Fahrenheit" && comboBox2.Text == "Celsius")
            {
                resultTemp = ((startingTemp - 32) / 1.8);
                label3.Text = resultTemp.ToString() + " Degrees Celsius";
            }
        }
    }
}
