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
    public partial class Imperial : Form
    {
        public Imperial()
        {
            InitializeComponent();
        }

        private void imperialButton_Click(object sender, EventArgs e)
        {
            double weight;
            double height;
            double bmi;
            weight = double.Parse(weightITextBox.Text);
            height = double.Parse(heightITextBox.Text);

            bmi = (weight * 703) / (height * height);

            if (bmi < 18.5)
            {
                resultILabel.Text = bmi + "\n UnderWeight";
            }

            else if (bmi > 18.5 && bmi < 24.9)
            {
                resultILabel.Text = bmi + "\n Normal";
            }

            else if (bmi > 25 && bmi < 29.9)
            {
                resultILabel.Text = bmi + "\n OverWeight";
            }

            else if (bmi > 30)
            {
                resultILabel.Text = bmi + "\n Obese";
            }
        }

        private void Imperial_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.bmiCalculatorForm.Show();
        }
    }
}
