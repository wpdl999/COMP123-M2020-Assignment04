using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_Assignment04
{
    static class Program
    {
        public static SplashForm splashForm;
        public static BMICalculatorForm bmiCalculatorForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            splashForm = new SplashForm();
            bmiCalculatorForm = new BMICalculatorForm();

            Application.Run(splashForm);
        }
    }
}
