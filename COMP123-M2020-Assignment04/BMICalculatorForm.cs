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

        private void MetricButton_Click(object sender, EventArgs e)
        {
            if (MetricButton.Checked) {
                Program.metric_Units.Show();
            }
        }

        private void ImperialButton_Click(object sender, EventArgs e)
        {
            if()
        }
    }
}
