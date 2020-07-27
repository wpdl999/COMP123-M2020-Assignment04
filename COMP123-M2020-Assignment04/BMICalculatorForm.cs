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
    public partial class BMICalculatorForm : Form
    {
        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            int weight;
            int height;
            int bmi;
            weight = int.Parse(weightTextBox.Text);
            height = int.Parse(heightTextBox.Text);

            bmi = (height * height) / weight;

            if (bmi < 18.5)
            {
                resultLabel.Text = bmi + "\n UnderWeight";
            }

            else if (bmi > 18.5 && bmi < 24.9)
            {
                resultLabel.Text = bmi + "\n Normal";
            }

            else if (bmi > 25 && bmi < 29.9)
            {
                resultLabel.Text = bmi + "\n OverWeight";
            }

            else if (bmi > 30)
            {
                resultLabel.Text = bmi + "\n Obese";
            }
        }
    }
}
