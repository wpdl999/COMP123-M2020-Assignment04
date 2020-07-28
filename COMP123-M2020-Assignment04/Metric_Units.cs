using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_Assignment04
{
    public partial class Metric_Units : Form
    {
        public Metric_Units()
        {
            InitializeComponent();
        }

        private void mertricButton_Click(object sender, EventArgs e)
        {
            double weight;
            double height;
            double bmi;
            weight = double.Parse(weightMTextBox.Text);
            height = double.Parse(heightMTextBox.Text);

            bmi = weight / (height * height) ;

            if (bmi < 18.5)
            {
                resultMLabel.Text = bmi + "\n UnderWeight";
            }

            else if (bmi > 18.5 && bmi < 24.9)
            {
                resultMLabel.Text = bmi + "\n Normal";
            }

            else if (bmi > 25 && bmi < 29.9)
            {
                resultMLabel.Text = bmi + "\n OverWeight";
            }

            else if (bmi > 30)
            {
                resultMLabel.Text = bmi + "\n Obese";
            }
        }

        private void BackMButton_Click(object sender, EventArgs e)
        {
            Program.bmiCalculatorForm.Show();
        }

        private void Metric_Units_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
