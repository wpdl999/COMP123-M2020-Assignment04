using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        private void MetricButton_Click(object sender, EventArgs e)
        {
            double weight;
            double height;
            double bmi;

            if (MetricButton.Checked) 
            {
                weight = double.Parse(weightTextBox.Text);
                height = double.Parse(heightTextBox.Text);
                height = height / 100;

                bmi = weight / (height * height);

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

        private void ImperialButton_Click(object sender, EventArgs e)
        {
            double weight;
            double height;
            double bmi;

            if (ImperialButton.Checked) 
            {
                weight = double.Parse(weightTextBox.Text);
                height = double.Parse(heightTextBox.Text);
                height = height * 0.393701;
                weight = weight * 2.20462;

                bmi = (weight * 703) / (height * height);

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

        private void BMICalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            weightTextBox.Text = string.Empty;
            heightTextBox.Text = string.Empty;
            resultLabel.Text = string.Empty;
            MetricButton.Checked = false;
            ImperialButton.Checked = false;
        }

        private void heightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void weightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
