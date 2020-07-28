using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_Assignment04
{
    static class Program
    {
        public static Metric_Units metric_Units;
        public static BMICalculatorForm bmiCalculatorForm;
        public static Imperial imperial;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            metric_Units = new Metric_Units();
            bmiCalculatorForm = new BMICalculatorForm();
            imperial = new Imperial();

            Application.Run(new BMICalculatorForm());
        }
    }
}
